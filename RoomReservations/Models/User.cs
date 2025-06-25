using Microsoft.AspNetCore.Identity;

namespace RoomReservations.Models;

public class User 
{
    public string Id { get; set; } = new Guid().ToString();
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = "user";
    public Decimal Balance { get; set; } 
    public int NumberOfRoom { get; set; }
    
}
