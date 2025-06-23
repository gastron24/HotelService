using Microsoft.AspNetCore.Identity;

namespace RoomReservations.Models;

public class User : IdentityUser
{
    public string Role { get; set; } = "User";
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public int NumberOfRooms { get; set; }
}