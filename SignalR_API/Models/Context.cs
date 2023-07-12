using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace SignalR_API.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JNJNVEQ\\MERTSQL;initial catalog=DbSignalR;integrated security=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
