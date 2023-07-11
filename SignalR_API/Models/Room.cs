using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace SignalR_API.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public List<User> Users { get; set; }
    }
}
