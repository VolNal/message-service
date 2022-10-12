using Microsoft.AspNetCore.Mvc;
using VolNal.Chat.MessageService.Hubs;
using VolNal.Chat.MessageService.Models;

namespace VolNal.Chat.MessageService.Controllers;

[ApiController]
[Route("api/chat/messages")]
public class MessageController: Controller
{
    private readonly ChatHub _hub;

    public MessageController(ChatHub hub)
    {
        _hub = hub;
    }

    [HttpPost("Disconnected")]
    public async Task Disconnected(Exception exception)
    {
        await _hub.OnDisconnectedAsync(exception);
    }
    
    [HttpPost("Join")]
    public async Task JoinRoom(UserConnection userConnection)
    {
        await _hub.JoinRoom(userConnection);
    }
}