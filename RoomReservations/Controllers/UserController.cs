using Microsoft.AspNetCore.Mvc;

namespace RoomReservations.Controllers;

public class UserController : ControllerBase
{

    [ApiController]
    [Route("api/user")]

    [HttpGet]
    public IActionResult GetInfoUser()
    {
        
    }



}