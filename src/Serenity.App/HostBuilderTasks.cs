// MIT License
//
// Copyright (c) 2023 SirRandoo
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Remora.Discord.API.Abstractions.Gateway.Commands;
using Remora.Discord.Commands.Extensions;
using Remora.Discord.Extensions.Extensions;
using Remora.Discord.Gateway;
using Remora.Discord.Hosting.Extensions;

namespace Serenity.App;

public static class HostBuilderTasks
{
    public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
       .AddDiscordService(RegisterDiscordService)
       .ConfigureServices(ConfigureDiscordService)
       .ConfigureServices(ConfigureDatabase)
       .ConfigureLogging(ConfigureHttpLogging)
       .UseConsoleLifetime();

    public static string RegisterDiscordService(IServiceProvider provider)
    {
        var configuration = provider.GetRequiredService<IConfiguration>();
        var token = configuration.GetValue<string?>("DISCORD_BOT_TOKEN");

        if (string.IsNullOrEmpty(token))
        {
            throw new InvalidOperationException("No Discord token was provided. To provide a Discord token, set the DISCORD_BOT_TOKEN environment variable.");
        }

        return token;
    }

    public static void ConfigureDatabase(HostBuilderContext context, IServiceCollection collection)
    {
        var postgresHost = context.Configuration.GetValue<string?>("POSTGRES_HOST");
        var postgresUser = context.Configuration.GetValue<string?>("POSTGRES_USER");
        var postgresPass = context.Configuration.GetValue<string?>("POSTGRES_PASS");
        var postgresData = context.Configuration.GetValue<string?>("POSTGRES_DATABASE");

        if (string.IsNullOrEmpty(postgresHost))
        {
            throw new InvalidOperationException("No PostgreSQL host was provided. To provide a host, set the POSTGRES_HOST environment variable.");
        }

        if (string.IsNullOrEmpty(postgresUser))
        {
            throw new InvalidOperationException("No PostgreSQL username was provided. To provide a username, set the POSTGRES_USER environment variable.");
        }

        if (string.IsNullOrEmpty(postgresPass))
        {
            throw new InvalidOperationException("No PostgreSQL password was provided. To provide a password, set the POSTGRES_PASS environment variable.");
        }

        if (string.IsNullOrEmpty(postgresData))
        {
            throw new InvalidOperationException("No PostgreSQL database was provided. To provide a database, set the POSTGRES_DATA environment variable.");
        }

        var connectionString = $"Host={postgresHost};Username={postgresUser};Password={postgresPass};Database={postgresData}";
        collection.AddNpgsqlDataSource(connectionString);
    }

    public static void ConfigureDiscordService(HostBuilderContext context, IServiceCollection collection)
    {
        collection.Configure<DiscordGatewayClientOptions>(options => options.Intents |= GatewayIntents.MessageContents);
        collection.AddDiscordCommands(true).AddCommandGroupsFromAssembly(Assembly.GetCallingAssembly());
    }

    public static void ConfigureHttpLogging(ILoggingBuilder builder)
    {
        builder.AddConsole().AddFilter("System.Net.HttpClient.*.LogicalHandler", LogLevel.Warning).AddFilter("System.Net.HttpClient.*.ClientHandler", LogLevel.Warning);
    }
}
