﻿using LiteNetwork;
using LiteNetwork.Hosting;
using LiteNetwork.Server.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Rhisis.Core.Configuration;
using Rhisis.Core.Extensions;
using Rhisis.Infrastructure.Logging;
using Rhisis.Infrastructure.Persistance;
using Rhisis.LoginServer.Core;
using Rhisis.Protocol;
using System;
using System.Threading.Tasks;

namespace Rhisis.LoginServer;

internal static class Program
{
    static async Task Main(string[] args)
    {
        const string culture = "en-US";

        Console.Title = "Rhisis - Login Server";
        var host = new HostBuilder()
           .ConfigureAppConfiguration((_, config) =>
           {
               config.AddEnvironmentVariables();
               config.SetBasePath(EnvironmentExtension.GetCurrentEnvironementDirectory());
               config.AddYamlFile("config/login-server.yml", optional: false, reloadOnChange: true);
           })
           .ConfigureServices((hostContext, services) =>
           {
               services.AddOptions();
               services.Configure<LoginServerOptions>(hostContext.Configuration.GetSection("server"));
               services.Configure<CoreCacheServerOptions>(hostContext.Configuration.GetSection("core-cache-server"));

               services.AddAccountPersistance(hostContext.Configuration.GetSection("account-database").Get<DatabaseOptions>());

               services.AddSingleton<IClusterCache, CoreCacheServer>(serviceProvider => serviceProvider.GetRequiredService<CoreCacheServer>());
           })
           .ConfigureLogging(builder =>
           {
               builder.AddConsole();
               builder.AddLoggingFilters();
           })
           .ConfigureLiteNetwork((context, builder) =>
           {
               builder.AddLiteServer<LoginServer>(options =>
               {
                   var serverOptions = context.Configuration.GetSection("server").Get<LoginServerOptions>();

                   if (serverOptions is null)
                   {
                       throw new InvalidProgramException($"Failed to load login server settings.");
                   }

                   options.Host = serverOptions.Ip;
                   options.Port = serverOptions.Port;
                   options.PacketProcessor = new FlyffPacketProcessor();
                   options.ReceiveStrategy = ReceiveStrategyType.Queued;
               });
               builder.AddLiteServer<CoreCacheServer>(options =>
               {
                   var serverOptions = context.Configuration.GetSection("core-cache-server").Get<CoreCacheServerOptions>();

                   if (serverOptions is null)
                   {
                       throw new InvalidProgramException($"Failed to load core cache server settings.");
                   }

                   options.Host = serverOptions.Ip;
                   options.Port = serverOptions.Port;
                   options.ReceiveStrategy = ReceiveStrategyType.Queued;
               });
           })
           .UseConsoleLifetime()
           .SetConsoleCulture(culture)
           .Build();

        await host.RunAsync();
    }
}
