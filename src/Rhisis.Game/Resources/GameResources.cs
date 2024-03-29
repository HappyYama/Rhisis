﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Rhisis.Core;
using Rhisis.Game.IO;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;

namespace Rhisis.Game.Resources;

public class GameResources : Singleton<GameResources>
{
    private ILogger<GameResources> _logger;
    private readonly ConcurrentDictionary<string, int> _defines = new();
    private readonly ConcurrentDictionary<string, string> _texts = new();

    public ItemResources Items { get; private set; }

    public MoverResources Movers { get; private set; }

    public NpcResources Npcs { get; private set; }
    
    public SkillResources Skills { get; private set; }

    public JobResources Jobs { get; private set; }

    public ExperienceTableResources ExperienceTable { get; private set; }

    public PenalityResources Penalities { get; private set; }

    public MapResources Maps { get; private set; }

    public QuestResources Quests { get; private set; }

    public void Initialize(IServiceProvider serviceProvider)
    {
        _logger = serviceProvider.GetRequiredService<ILogger<GameResources>>();
        LoadDefines();
        LoadTexts();

        Items = new(serviceProvider.GetRequiredService<ILogger<ItemResources>>(), _defines);
        Movers = new(serviceProvider.GetRequiredService<ILogger<MoverResources>>(), _defines);
        Npcs = new(serviceProvider.GetRequiredService<ILogger<NpcResources>>());
        Skills = new(serviceProvider.GetRequiredService<ILogger<SkillResources>>(), _defines);
        Jobs = new(serviceProvider.GetRequiredService<ILogger<JobResources>>(), _defines);
        ExperienceTable = new(serviceProvider.GetRequiredService<ILogger<ExperienceTableResources>>());
        Penalities = new(serviceProvider.GetRequiredService<ILogger<PenalityResources>>());
        Maps = new(serviceProvider.GetRequiredService<ILogger<MapResources>>(), _defines);
        Quests = new(serviceProvider.GetRequiredService<ILogger<QuestResources>>(), _defines);
    }

    public int GetDefinedValue(string identifierName) => _defines.TryGetValue(identifierName, out int value) ? value : default;

    public string GetText(string identifierName) => _texts.TryGetValue(identifierName, out string text) ? text : default;

    private void LoadDefines()
    {
        var headerFiles = from x in Directory.GetFiles(GameResourcePaths.ResourcePath, "*.*", SearchOption.AllDirectories)
                          where DefineFile.Extensions.Contains(Path.GetExtension(x))
                          select x;

        foreach (var headerFile in headerFiles)
        {
            using DefineFile defineFile = new(headerFile);
            
            foreach (var define in defineFile.Values)
            {
                var isIntValue = int.TryParse(define.Value.ToString(), out var intValue);

                if (isIntValue && !_defines.ContainsKey(define.Key))
                {
                    _defines.TryAdd(define.Key, intValue);
                }
            }
        }

        _logger.LogTrace("Definitions loaded from resources (*.h).");
    }

    private void LoadTexts()
    {
        var textFiles = from x in Directory.GetFiles(GameResourcePaths.ResourcePath, "*.*", SearchOption.AllDirectories)
                        where TextFile.Extensions.Contains(Path.GetExtension(x)) && x.EndsWith(".txt.txt")
                        select x;

        foreach (var textFilePath in textFiles)
        {
            using TextFile textFile = new(textFilePath);

            foreach (var text in textFile.Texts)
            {
                _texts.TryAdd(text.Key, text.Value);
            }
        }

        _logger.LogTrace("Texts loaded from resources (*.txt.txt).");
    }
}
