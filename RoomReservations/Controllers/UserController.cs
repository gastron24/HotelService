using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using RoomReservations.Data;
using RoomReservations.Models;

namespace RoomReservations.Controllers;

[ApiController]
[Route("api/user/[controller]")]
public class UserController : ControllerBase
{
    private User _user;
    private RoomReservationDb _db;
    
    public UserController(RoomReservations.Models.User user, RoomReservations.Data.RoomReservationDb db)
    {
        _user = user;
        _db = db;
    }

    [HttpPost]
    public IActionResult ReserveRoom()
    {
        
    }
    
    
    [HttpGet]
    public IActionResult GetInfoReserve()
    {
        if (_user == null)
        {
            return NotFound($"Пользователя {_user} не существует.");
        }

        return Ok(_user);
    }

    
    
    



}