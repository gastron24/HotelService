using Duende.IdentityServer.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoomReservations.Models;

namespace RoomReservations.Data
{
    public class RoomReservationDb : IdentityDbContext
    {
        public RoomReservationDb(DbContextOptions<RoomReservationDb> options)
            : base(options) { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> User { get; set; }
        
    }
}