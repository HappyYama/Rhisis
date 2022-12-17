﻿namespace Rhisis.Core.Structures.Configuration;

/// <summary>
/// Contains contants related to the configuration.
/// </summary>
public sealed class ConfigurationConstants
{
    /// <summary>
    /// Gets the default configuration path when Rhisis is running inside a container.
    /// </summary>
    public const string DefaultRhisisDockerConfigurationPath = "/var/rhisis";

    /// <summary>
    /// Gets the Rhisis docker configuration environment key.
    /// </summary>
    public const string RhisisDockerConfigurationKey = "RHISIS_CONFIGURATION";

    /// <summary>
    /// Gets the CoreServer configuration path.
    /// </summary>
    public const string CoreServerPath = "./config/core.json";

    /// <summary>
    /// Gets the LoginServer configuration file path.
    /// </summary>
    public const string LoginServerPath = "./config/login.json";

    /// <summary>
    /// Gets the ClusterServer configuration file path.
    /// </summary>
    public const string ClusterServerPath = "./config/cluster.json";
    
    /// <summary>
    /// Gets the WorldClusterServer configuration key.
    /// </summary>
    public const string WorldClusterServer = "worldClusterServer";

    /// <summary>
    /// Gets the WorldServer configuration file path.
    /// </summary>
    public const string WorldServerPath = "./config/world.json";

    /// <summary>
    /// Gets the Database configuration file path.
    /// </summary>
    public const string DatabasePath = "config/database.json";

    /// <summary>
    /// Gets the Database configuration key.
    /// </summary>
    public const string DatabaseConfiguration = "databaseConfiguration";

    /// <summary>
    /// Prevents from creating a <see cref="ConfigurationConstants"/> instance from outside.
    /// </summary>
    private ConfigurationConstants()
    {
    }
}
