using Microsoft.AspNetCore.Mvc;
using RoomReservations.Dto;

[ApiController]
[Route("api/user/[controller]")]
public class UserController : ControllerBase
{
    private readonly IReservationService _reservationService;

    public UserController(IReservationService reservationService) => 
        _reservationService = reservationService;

    [HttpPost("reserve")]
    public async Task<IActionResult> ReserveRoom([FromBody] ReservationDto dto)
    {
        try
        {
            var reservation = new Reservation
            {
                RoomId = dto.RoomId,
                StartDate = dto.StartTime,
                EndDate = dto.EndTime
            };

            var createdReservation = await _reservationService.CreateReservationAsync(reservation, dto.UserId);
            return CreatedAtAction(nameof(GetMyReservations), new { id = createdReservation.Id }, createdReservation);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("reservations/{userId}")]
    public async Task<IActionResult> GetMyReservations(string userId)
    {
        var reservations = await _reservationService.GetReservationsByUserIdAsync(userId);
        return Ok(reservations);
    }
}