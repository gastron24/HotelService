using Microsoft.EntityFrameworkCore;
using RoomReservations.Data;
using RoomReservations.Models;
using RoomReservations.Services;
public class ReservationService : IReservationService
{
    private readonly RoomReservationDb _db;

    public ReservationService(RoomReservationDb db) => _db = db;

    public async Task<Reservation> CreateReservationAsync(Reservation reservation, string userId)
    {
        if (reservation.EndDate <= reservation.StartDate)
            throw new ArgumentException("Дата окончания должна быть позже даты начала или наоборот я сам запутался бля.");

        var room = await _db.Rooms
            .Include(r => r.Reservations)
            .FirstOrDefaultAsync(r => r.Id == reservation.RoomId);

        if (room == null)
            throw new Exception("Комната не найдена.");
        
        if (room.Reservations.Any(r => 
            r.StartDate <= reservation.EndDate && r.EndDate >= reservation.StartDate))
        {
            throw new Exception("Комната уже забронирована на эти дни.");
        }

        reservation.UserId = userId;
        _db.Reservations.Add(reservation);
        await _db.SaveChangesAsync();
        return reservation;
    }

    public async Task<List<Reservation>> GetReservationsByUserIdAsync(string userId)
    {
        return await _db.Reservations
            .Where(r => r.UserId == userId)
            .Include(r => r.Room)
            .ToListAsync();
    }
}

