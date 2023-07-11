using Microsoft.AspNetCore.SignalR;
using SignalR_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR_API.Hubs
{
    public class MyHub : Hub
    {
        private readonly Context _context;

        public MyHub(Context context)
        {
            _context = context;
        }

        public static List<string> Names { get; set; } = new List<string>();

        public static int ClientCount { get; set; } = 0;
        public static int RoomCount { get; set; } = 5;

        public async Task SendName(string name)
        {
            Names.Add(name);
            await Clients.All.SendAsync("ReceiverName",name);
        }

        public async Task GetNames()
        {
            await Clients.All.SendAsync("ReceiverNames",Names);
        }

    }
}
