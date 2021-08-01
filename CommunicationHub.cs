using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace RandomSixOnline
{
    public class CommunicationHub : Hub
    {

        public async Task SendPlayer(Player player, string groupName)
        {
            await Clients.Group(groupName).SendAsync("GetPlayer", player);
        }
        public Task JoinRoom(string roomName)
        {
            return Groups.AddToGroupAsync(this.Context.ConnectionId, roomName);
            //Leave a message or add html with player joined.
        }
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }

        public Task LeaveRoom(string roomName)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }

        public Task SendMesssageToGroup(string group, string message)
        {
            return Clients.Group(group).SendAsync(message);
        }
    }
}
