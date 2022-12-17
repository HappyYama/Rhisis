﻿using System.Collections.Generic;

namespace Rhisis.Abstractions.Server;

/// <summary>
/// Defines the cluster server data structure.
/// </summary>
public class Cluster : BaseServer
{
    /// <summary>
    /// Gets the list of connected world channels for the current cluster.
    /// </summary>
    public IList<WorldChannel> Channels { get; set; } = new List<WorldChannel>();
}
