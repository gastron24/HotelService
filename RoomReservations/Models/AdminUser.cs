using Microsoft.AspNetCore.Identity;

namespace RoomReservations.Models;

public class AdminUser 
{
    public AdminUser(string username, string password, Guid id, string role)
    {
        this.Username = username;
        this.Password = password;
        this.Role = "Admin";
        id = Guid.NewGuid();
    }
}