using Microsoft.AspNetCore.Identity;

namespace RoomReservations.Models;

public class User : IdentityUser
{
    public string Role { get; set; } = "User";
    public decimal Balance { get; set; }
}