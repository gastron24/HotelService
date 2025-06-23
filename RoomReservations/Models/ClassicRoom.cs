namespace RoomReservations.Models;

public class ClassicRoom
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal PriceRoom { get; set; }
    public bool IsReserved { get; set; } = false;
}