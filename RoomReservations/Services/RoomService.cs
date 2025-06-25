using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using RoomReservations.Data;
using RoomReservations.Models;
using RoomReservations.Services;

public class RoomService : IRoomService
{
    private readonly RoomReservationDb _db;

    public RoomService(RoomReservationDb db) => _db = db;

    public async Task<List<Room>> GetAllRoomsAsync()
    {
        return await _db.Rooms.ToListAsync();
    }

    public async Task<Room> GetRoomByIdAsync(Guid id)
    {
        return await _db.Rooms
            .Include(r => r.Reservations)
            .FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<Room> CreateRoomAsync(Room room)
    {
        _db.Rooms.Add(room);
        await _db.SaveChangesAsync();
        return room;
    }

    public async Task DeleteRoomAsync(Guid id)
    {
        var room = await _db.Rooms.FindAsync(id);
        if (room != null)
        {
            _db.Rooms.Remove(room);
            await _db.SaveChangesAsync();
        }

    }
}