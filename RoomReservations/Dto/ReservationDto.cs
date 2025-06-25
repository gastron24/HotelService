namespace RoomReservations.Dto;

public class ReservationDto
{
    public Guid RoomId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string UserId { get; set; } = string.Empty;
}