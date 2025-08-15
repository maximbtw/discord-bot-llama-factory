using Bot.Domain.Message;
using DSharpPlus.Entities;

namespace Bot.Application;

internal static class DiscordContentMapper
{
    public static MessageOrm MapDiscordMessage(DiscordMessage message)
    {
        return new MessageOrm
        {
            Id = (long)message.Id,
            UserId = (long)message.Author!.Id,
            UserName = message.Author.Username,
            ChannelId =(long) message.Channel!.Id,
            ServerId = (long)message.Channel.GuildId!,
            Content = message.Content,
            Timestamp = message.Timestamp.UtcDateTime,
            UserIsBot = message.Author.IsBot,
            ReplyToMessageId = (long?)message.ReferencedMessage?.Id,
            HasAttachments = message.Attachments.Count > 0,
            MentionedUserIds = message.MentionedUsers.Select(u => (long)u.Id).ToList()
        };
    }

}