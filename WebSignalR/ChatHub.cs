using Microsoft.AspNetCore.SignalR;

namespace WebSignalR
{
    public class ChatHub : Hub
    {
        public async Task SendMessage( string message, string id)
        {
            await Clients.Client(id).SendAsync("ReceiveMessage", message,id);
        }
        public async Task GetMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
