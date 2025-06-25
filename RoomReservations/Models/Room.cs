namespace RoomReservations.Models;

public class Room
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public decimal PriceRoom { get; set; }
    public string Description { get; set; } = string.Empty; 
    public int ClassRoom { get; set; } 
    
    public List<Reservation> Reservations { get; set; } = new();
}