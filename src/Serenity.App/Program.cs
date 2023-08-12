using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Remora.Discord.API;
using Remora.Discord.Commands.Services;
using Remora.Rest.Core;
using Remora.Results;

namespace Serenity.App;

internal abstract class Program
{
    protected Program()
    {
    }

    public static async Task Main(string[] args)
    {
        IHost host = HostBuilderTasks.CreateHostBuilder(args).Build();

    #if DEBUG
        await UpdateDebugServerCommands(host.Services);
    #endif

        await host.RunAsync();
    }

    private static async Task UpdateDebugServerCommands(IServiceProvider services)
    {
        var log = services.GetRequiredService<ILogger<Program>>();
        var configuration = services.GetRequiredService<IConfiguration>();
        var debugServerId = configuration.GetValue<string?>("DEBUG_SERVER_SNOWFLAKE");

        if (string.IsNullOrEmpty(debugServerId))
        {
            return;
        }

        if (!DiscordSnowflake.TryParse(debugServerId, out Snowflake? snowflake))
        {
            log.LogWarning("Could not parse debug server id. Commands will not be updated within the server.");

            return;
        }

        var service = services.GetRequiredService<SlashService>();
        Result result = await service.UpdateSlashCommandsAsync(snowflake);

        if (!result.IsSuccess)
        {
            log.LogWarning("Failed to update slash commands in debug server. Reason: {Reason}", result.Error.Message);
        }
    }
}
