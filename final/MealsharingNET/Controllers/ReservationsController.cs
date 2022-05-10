using MealsharingNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("api/reservation")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("")]
    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        return await _repo.ListReservations();
    }

    [HttpGet("{id}")]
    public async Task<List<Reservation>> GetMealReservations(int id)
    {
        return await _repo.GetMealReservations(id);
    }
    [HttpPost("")]
    public async Task AddReservation([FromBody] Reservation r)
    {
        await _repo.AddReservation(r);
    }

    [HttpPatch("")]
    public async Task UpdateReservation([FromBody] Reservation r)
    {
        await _repo.UpdateReservation(r);
    }
    [HttpDelete("")]
    public async Task DeleteReservation(int id)
    {
        await _repo.DeleteReservation(id);
    }
}