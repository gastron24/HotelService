using RoomReservations.Models;

namespace RoomReservations.Services;

public interface IRoomService
{
    Task<List<Room>> GetAllRoomsAsync();
    Task<Room> GetRoomByIdAsync(Guid id);
    Task<Room> CreateRoomAsync(Room room);
    Task DeleteRoomAsync(Guid id);
    
}

public interface IReservationService
{
    Task<List<Reservation>> GetReservationsByUserIdAsync(string userId);
    Task<Reservation> CreateReservationAsync(Reservation reservation);
}