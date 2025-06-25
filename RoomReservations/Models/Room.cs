namespace RoomReservations.Models;

public class Room
{
    public Guid NumberRoom { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal PriceRoom { get; set; }
    public bool IsReserved { get; set; } = false;
}