using Npgsql;
using Remora.Commands.Groups;
using Remora.Discord.Commands.Feedback.Services;
using Remora.Results;

namespace Serenity.Modules.Advertising;

public class TwitchAdvertisingCommands : CommandGroup
{
    private readonly NpgsqlConnection _connection;
    private readonly FeedbackService _feedbackService;

    public TwitchAdvertisingCommands(NpgsqlConnection connection, FeedbackService service)
    {
        _connection = connection;
        _feedbackService = service;
    }

    public async Task<IResult> RegisterUsername(string username)
    {
        // TODO

        return await _feedbackService.SendContextualAsync("hello world");
    }
}
