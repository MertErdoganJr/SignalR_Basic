using Microsoft.AspNetCore.Mvc.Formatters;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace SignalR_API.Models
{

    public class Room
    {
        public Room()
        {
            Users = new List<User>();
        }

        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public List<User> Users { get; set; }
    }
}
