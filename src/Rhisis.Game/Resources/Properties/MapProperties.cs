﻿using System.Collections.Generic;

namespace Rhisis.Game.Resources.Properties;

public sealed class MapProperties
{
    public static readonly int RegionSize = 128;

    /// <summary>
    /// Gets the map id.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Gets the map name.
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Gets the map width in number of lands.
    /// </summary>
    public int Width { get; init; }

    /// <summary>
    /// Gets the map length in number of lands.
    /// </summary>
    public int Length { get; init; }

    /// <summary>
    /// Gets the map heights.
    /// </summary>
    public float[] Heights { get; init; }

    /// <summary>
    /// Gets the revival map id when a player dies on this map.
    /// </summary>
    public int RevivalMapId { get; init; }

    /// <summary>
    /// Gets the map MPU. (Meters Per Unit)
    /// </summary>
    public int MPU { get; init; }

    /// <summary>
    /// Gets the map bounds.
    /// </summary>
    public Rectangle Bounds { get; init; }

    /// <summary>
    /// Gets the map regions.
    /// </summary>
    public IEnumerable<MapRegionProperties> Regions { get; init; }

    /// <summary>
    /// Gets the map static objects.
    /// </summary>
    public IEnumerable<MapObjectProperties> Objects { get; init; }
}
