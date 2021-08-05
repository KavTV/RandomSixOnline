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
            player.ConnectionId = this.Context.ConnectionId;
            await Clients.Group(groupName).SendAsync("GetPlayer", player);
        }
        public async Task CreateRoom(string roomName)
        {
            ClientGroups.groupName = roomName;
            await Groups.AddToGroupAsync(this.Context.ConnectionId, roomName);

        }
        public async Task JoinRoomAndSendPlayer(string roomName, Player player)
        {
            //Save the groupid
            ClientGroups.groupName = roomName;
            //Join group
            await Groups.AddToGroupAsync(this.Context.ConnectionId, roomName);
            
            //Save the connectionId
            player.ConnectionId = this.Context.ConnectionId; 

            //Tells other players that you joined.
            await Clients.OthersInGroup(roomName).SendAsync("PlayerConnected", player);
            await SendPlayer(player, roomName);
        }
        public async Task GetOtherPlayers(Player player, string groupName)
        {
            await Clients.OthersInGroup(groupName).SendAsync("GetPlayer", player);
        }
        public async override Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }
        public async override Task OnDisconnectedAsync(Exception exception)
        {
             await PlayerDisconnected();
        }

        public async Task LeaveRoom(string roomName)
        {
            ClientGroups.groupName = "";
            await PlayerDisconnected();
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }
        private async Task PlayerDisconnected()
        {
            await Clients.Group(ClientGroups.groupName).SendAsync("PlayerDisconnected", this.Context.ConnectionId);
        }
        public async Task SendMesssageToGroup(string group, string message)
        {
            await Clients.Group(group).SendAsync(message);
        }
        public async Task SendMessageToConnectionId(string connectionid, string message)
        {
            await Clients.Client(connectionid).SendAsync(message);
        }
    }
}
