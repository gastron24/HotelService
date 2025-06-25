using Microsoft.AspNetCore.Mvc;
using RoomReservations.Models;
using RoomReservations.Services;

[ApiController]
[Route("api/admin/[controller]")]
public class AdminController : ControllerBase
{
    private readonly IRoomService _roomService;

    public AdminController(IRoomService roomService) => _roomService = roomService;

    [HttpPost]
    public async Task<IActionResult> CreateRoom([FromBody] Room room)
    {
        var createdRoom = await _roomService.CreateRoomAsync(room);
        return CreatedAtAction(nameof(GetRoomById), new { id = createdRoom.Id }, createdRoom);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteRoom(Guid id)
    {
        await _roomService.DeleteRoomAsync(id);
        return NoContent();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetRoomById(Guid id)
    {
        var room = await _roomService.GetRoomByIdAsync(id);
        return Ok(room);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRooms()
    {
        var rooms = await _roomService.GetAllRoomsAsync();
        return Ok(rooms);
    }
}