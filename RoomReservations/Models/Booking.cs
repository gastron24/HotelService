namespace RoomReservations.Models;

public class Booking
{
    public Guid Id { get; set; }
    public Guid RoomId { get; set; }
    public string UserId { get; set; }
    public DateTime ChechIn { get; set; }
    public DateTime ChechOut { get; set; }
    public bool IsConfirmed { get; set; }

}