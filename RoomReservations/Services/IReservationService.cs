using RoomReservations.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IReservationService
{
    Task<Reservation> CreateReservationAsync(Reservation reservation, string userId);
    Task<List<Reservation>> GetReservationsByUserIdAsync(string userId);
}