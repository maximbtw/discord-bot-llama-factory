using DSharpPlus.Commands;
using DSharpPlus.Entities;

namespace Bot.Application.UseCases.Ai;

public class CreateDatasetUseCase
{
    public async ValueTask Execute(
        CommandContext context, 
        CancellationToken ct = default)
    {
        await context.RespondAsync("Команда еще не реализована");
    }
}