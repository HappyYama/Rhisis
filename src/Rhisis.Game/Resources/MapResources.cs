﻿using Microsoft.Extensions.Logging;
using Rhisis.Game.Common;
using Rhisis.Game.IO;
using Rhisis.Game.IO.Dyo;
using Rhisis.Game.IO.Rgn;
using Rhisis.Game.IO.World;
using Rhisis.Game.Resources.Properties;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Rhisis.Game.Resources;

public sealed class MapResources
{
    private readonly ILogger<MapResources> _logger;
    private readonly ConcurrentDictionary<string, int> _defines;
    private readonly ConcurrentDictionary<int, MapProperties> _mapsById = new();
    private readonly ConcurrentDictionary<string, MapProperties> _mapsByIdentifier = new();

    public MapResources(ILogger<MapResources> logger, ConcurrentDictionary<string, int> defines)
    {
        _logger = logger;
        _defines = defines;
    }

    public IEnumerable<MapProperties> GetAll() => _mapsById.Values;

    public MapProperties Get(int mapId) => _mapsById.GetValueOrDefault(mapId);

    public void Load(params string[] mapIdentifiers)
    {
        Stopwatch watch = new();
        watch.Start();

        if (mapIdentifiers is not null && mapIdentifiers.Length > 0)
        {
            IReadOnlyDictionary<string, string> worldNames = LoadWorldScriptFile();

            foreach (string mapIdentifier in mapIdentifiers)
            {
                if (_mapsByIdentifier.ContainsKey(mapIdentifier))
                {
                    _logger.LogWarning($"Map '{mapIdentifier}' has been already loaded.");
                    continue;
                }

                if (!worldNames.TryGetValue(mapIdentifier, out var worldName))
                {
                    _logger.LogWarning($"Failed to load map with identifier: '{mapIdentifier}'. Map is not declared in {GameResourcePaths.WorldScriptPath}'.");
                    continue;
                }

                if (!_defines.TryGetValue(mapIdentifier, out int mapId))
                {
                    _logger.LogWarning($"Failed to load map with identifier: '{mapIdentifier}'. Map id has not been defined in {GameResourcePaths.DataSub0Path}/defineWorld.h'.");
                    continue;
                }

                WldFileInformations worldInformation = LoadWorldInformation(worldName);

                int revivalMapId = worldInformation.RevivalMapId == 0 ? mapId : worldInformation.RevivalMapId;
                MapProperties map = new()
                {
                    Id = mapId,
                    Name = worldName,
                    Width = worldInformation.Width,
                    Length = worldInformation.Length,
                    RevivalMapId = revivalMapId,
                    MPU = worldInformation.MPU,
                    Bounds = new Rectangle(0, 0, 
                        width: worldInformation.Width * worldInformation.MPU * MapProperties.RegionSize, 
                        length: worldInformation.Length * worldInformation.MPU * MapProperties.RegionSize),
                    Regions = LoadRegions(worldName, revivalMapId),
                    Objects = LoadObjects(worldName),
                    Heights = LoadHeights(worldName, worldInformation.Width, worldInformation.Length)
                };

                _mapsById.TryAdd(map.Id, map);
                _mapsByIdentifier.TryAdd(mapIdentifier, map);
            }
        }

        watch.Stop();
        _logger.LogInformation($"{_mapsById.Count} maps loaded in {watch.ElapsedMilliseconds}ms.");
    }

    private static IReadOnlyDictionary<string, string> LoadWorldScriptFile()
    {
        if (!File.Exists(GameResourcePaths.WorldScriptPath))
        {
            throw new InvalidOperationException($"Failed to load world script path: '{GameResourcePaths.WorldScriptPath}'.");
        }

        Dictionary<string, string> worldsPaths = new();

        using (TextFile textFile = new(GameResourcePaths.WorldScriptPath))
        {
            foreach (KeyValuePair<string, string> text in textFile.Texts)
            {
                worldsPaths.Add(text.Key, text.Value.Replace('"', ' ').Trim());
            }
        }

        return worldsPaths;
    }

    private static WldFileInformations LoadWorldInformation(string mapName)
    {
        var wldFilePath = Path.Combine(GameResourcePaths.MapsPath, mapName, $"{mapName}.wld");
        using WldFile wldFile = new(wldFilePath);

        return wldFile.WorldInformations;
    }

    private static IEnumerable<MapRegionProperties> LoadRegions(string mapName, int revivalMapId)
    {
        string regionFilePath = Path.Combine(GameResourcePaths.MapsPath, mapName, $"{mapName}.rgn");
        List<MapRegionProperties> regions = new();

        using (RgnFile regionFile = new(regionFilePath))
        {
            IEnumerable<MapRespawnRegionProperties> respawnersRgn = regionFile.GetElements<RgnRespawn7>()
                .Select(region => new MapRespawnRegionProperties
                {
                    X = region.Left,
                    Z = region.Top,
                    Width = region.Width,
                    Length = region.Length,
                    Time = region.Time,
                    Height = region.Position.Y,
                    ObjectType = (WorldObjectType)region.Type,
                    ModelId = region.Model,
                    Count = region.Count
                });

            regions.AddRange(respawnersRgn);

            foreach (RgnRegion3 region in regionFile.GetElements<RgnRegion3>())
            {
                MapRegionProperties mapRegion = (RegionInfoType)region.Index switch
                {
                    RegionInfoType.Revival => new MapRevivalRegionProperties
                    {
                        X = region.Left,
                        Z = region.Top,
                        Width = region.Width,
                        Length = region.Length,
                        MapId = revivalMapId,
                        Key = region.Key,
                        RevivalPosition = region.Position.Clone(),
                        IsChaoRegion = region.ChaoKey,
                        TargetRevivalKey = region.TargetKey
                    },
                    RegionInfoType.Trigger => new MapTriggerRegionProperties
                    {
                        X = region.Left,
                        Z = region.Top,
                        Width = region.Width,
                        Length = region.Length,
                        DestinationMapId = region.TeleportWorldId,
                        DestinationMapPosition = region.TeleportPosition.Clone()
                    },
                    // TODO: load collector regions
                    _ => null
                };

                if (region != null)
                {
                    regions.Add(mapRegion);
                }
            }
        }

        return regions;
    }

    private static IEnumerable<MapObjectProperties> LoadObjects(string mapName)
    {
        string dyoFilePath = Path.Combine(GameResourcePaths.MapsPath, mapName, $"{mapName}.dyo");
        using DyoFile dyoFile = new(dyoFilePath);

        return dyoFile.Elements
            .OfType<DyoNpcElement>()
            .Select(x => new MapObjectProperties
            {
                ModelId = x.Index,
                Position = x.Position.Clone(),
                Angle = x.Angle,
                Name = x.CharacterKey
            })
            .ToList();
    }

    private static float[] LoadHeights(string mapName, int width, int length)
    {
        const int LandscapeSize = 128;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < length; y++)
            {
                float[] landHeights = new float[(LandscapeSize + 1) * (LandscapeSize + 1)];
                string landFilePath = Path.Combine(GameResourcePaths.MapsPath, mapName, $"{mapName}{x:00}-{y:00}.lnd");

                if (File.Exists(landFilePath))
                {
                    using BinaryReader reader = new(File.Open(landFilePath, FileMode.Open, FileAccess.Read));

                    int version = reader.ReadInt32();

                    if (version >= 1)
                    {
                        byte[] heightmap = reader.ReadBytes(landHeights.Length * sizeof(float));
                        Buffer.BlockCopy(heightmap, 0, landHeights, 0, heightmap.Length);
                    }
                }
            }
        }

        return null;
    }
}
