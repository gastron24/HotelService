using Duende.IdentityServer.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoomReservations.Models;

namespace RoomReservations.Data
{
    public class RoomReservationDb : DbContext
    {
        public RoomReservationDb(DbContextOptions<RoomReservationDb> options)
            : base(options) { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        //тут должна быть связь один ко многим. но я не разобрался в ней(
    }
}