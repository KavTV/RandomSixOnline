#pragma checksum "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb189906f744b491621a40e006676242c8a4c7b5"
// <auto-generated/>
#pragma warning disable 1591
namespace RandomSixOnline.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using RandomSixOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\_Imports.razor"
using RandomSixOnline.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{groupId}")]
    public partial class OnlineRoom : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>OnlineRoom</h3>\r\n");
            __builder.OpenElement(1, "label");
            __builder.AddContent(2, "INFO: \"");
            __builder.AddContent(3, 
#nullable restore
#line 10 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
               errorLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, "\"");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 13 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
     if (string.IsNullOrWhiteSpace(groupId))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "class", "form-control field");
            __builder.AddAttribute(15, "id", "UsernameInput");
            __builder.AddAttribute(16, "placeholder", "Username");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                                                        player.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.Username = __value, player.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<label class=\"col field\">Create or join a room:</label>\r\n            ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "col btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                                          CreateRoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, " Create");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, "<label class=\"col\">Join</label>\r\n            ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "class", "form-control field");
            __builder.AddAttribute(37, "id", "groupPut");
            __builder.AddAttribute(38, "placeholder", "GroupID");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                                                   groupInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => groupInput = __value, groupInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "col btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                                          JoinRoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Join room");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 27 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.OpenElement(49, "label");
            __builder.AddContent(50, "You are in room: \"");
            __builder.AddContent(51, 
#nullable restore
#line 30 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                  groupId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, "\"");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 31 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                              RandomOperatorAndSend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "disabled", 
#nullable restore
#line 35 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                                                                 !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " Random Operator");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 39 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
     foreach (var player in players)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-md-6");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "img");
            __builder.AddAttribute(73, "class", true);
            __builder.AddAttribute(74, "src", "Images/" + (
#nullable restore
#line 42 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                        player.CurrentOperator

#line default
#line hidden
#nullable disable
            ) + ".webp");
            __builder.AddAttribute(75, "style", "width: 100px");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.OpenElement(77, "h5");
            __builder.AddAttribute(78, "class", "d-flex align-items-center");
            __builder.AddContent(79, 
#nullable restore
#line 43 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                                   player.Username

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(80, ": ");
            __builder.AddContent(81, 
#nullable restore
#line 43 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
                                                                     player.CurrentOperator

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 46 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\kasp609g\Documents\Github\RandomSixOnline\Pages\OnlineRoom.razor"
       
    private HubConnection hubConnection;
    //private List<string> messages = new List<string>();
    private string groupInput = ""; //This binds with input
    [Parameter]
    public string groupId { get; set; } //this is where the group gets stored.
    private string errorLabel = "";
    private bool groupJoined = false;
    private Player player = new Player();
    private List<Player> players = new List<Player>();

    protected override async Task OnInitializedAsync()
    {
        //Roll random operator
        player.GetRandomOperator();
        //player.ConnectionId = hubConnection.ConnectionId;
        //Maybe set to communicationhub
        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/onlineroom"))
        .Build();

        //When a player joins
        hubConnection.On<Player>("GetPlayer", player =>
        {
            errorLabel = "Spiller tilf??jet";

        //Find if user exists already, if exists then replace with new player object
        int index = players.FindIndex(p => p.ConnectionId == player.ConnectionId);
            if (index != -1)
            {
                players[index] = player;
            }
            else
            {
                players.Add(player);
            }
            StateHasChanged();
        });

        hubConnection.On<string>("PlayerDisconnected", player =>
        {
            errorLabel = "Player Disconnected";

        //Find if user exists already, if exists then replace with new player object
        int index = players.FindIndex(p => p.ConnectionId == player);
            if (index != -1)
            {
                players.Remove(players[index]);
            }

            StateHasChanged();
        });

        hubConnection.On<Player>("PlayerConnected", async receivedPlayer =>
        {
            errorLabel = receivedPlayer.Username;

            players.Add(receivedPlayer);

        //await hubConnection.SendAsync("GetOtherPlayers", groupId, this.player);
        await SendAPlayer();

            StateHasChanged();
        });
        hubConnection.On<Player>("SendPlayer", async nothing =>
        {
            errorLabel = nothing.Username;

            await SendAPlayer();

            StateHasChanged();
        });

        await hubConnection.StartAsync();

        //If group parameter is set, then join group
        if (!string.IsNullOrWhiteSpace(groupId) && groupJoined != true)
        {
            //set this or it will be overwritten in joinroom
            groupInput = groupId;
            await JoinRoom();
        }
    }


    async Task CreateRoom()
    {
        Random rnd = new Random();
        string group = "";
        for (int i = 0; i < 7; i++)
        {
            group += rnd.Next(1, 9);
        }
        groupId = group;
        await hubConnection.SendAsync("JoinRoomAndSendPlayer", group, player);
        //await SendAPlayer();
    }

    async Task JoinRoom()
    {
        errorLabel = "Rum tilsluttet";
        groupId = groupInput;
        groupJoined = true;
        await hubConnection.SendAsync("JoinRoomAndSendPlayer", groupId, player);
    }

    async Task SendAPlayer() =>
    await hubConnection.SendAsync("SendPlayer", this.player, this.groupId);

    public async void RandomOperatorAndSend()
    {
        player.GetRandomOperator();
        await SendAPlayer();
    }


    public bool IsConnected =>
    hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

    public void Dispose()
    {
        hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
