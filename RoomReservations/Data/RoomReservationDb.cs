using Duende.IdentityServer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using RoomReservations.Models;

namespace RoomReservations.Data
{
    public class RoomReservationDb : IdentityDbContext<ApplicationUser>
    {
        public RoomReservationDb(DbContextOptions<RoomReservationDb> options)
            : base(options) { }

        public DbSet<ClassicRoom> ClassicRooms { get; set; }
        public DbSet<PremiumRoom> PremiumRooms { get; set; }
    }
}