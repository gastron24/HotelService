using Duende.IdentityServer.EntityFramework;
using Duende.IdentityServer;
using Microsoft.EntityFrameworkCore;
using RoomReservations.Models;
namespace RoomReservations.Data;

public class RoomReservationDb : IdentityDbContext<RoomReservations>
{
    public RoomReservationDb(DbContextOptions<RoomReservationDb> options)
        : base(options) { }
    
    DbSet<ClassicRoom> ClassicRooms { get; set; }
    DbSet<PremiumRoom> PremiumRooms { get; set; }
    
    
}

