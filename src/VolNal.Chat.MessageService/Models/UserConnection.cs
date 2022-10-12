namespace VolNal.Chat.MessageService.Models;

public class UserConnection
{
    public string User { get; set; }
    public string Room { get; set; }
    public ChatType Type { get; set; }
}