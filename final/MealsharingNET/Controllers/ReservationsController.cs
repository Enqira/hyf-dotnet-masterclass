using MealsharingNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("Reservation")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        return await _repo.ListReservations();
    }

    [HttpGet("MealReservations")]
    public async Task<List<Reservation>> GetMealReservations(int id)
    {
        return await _repo.GetMealReservations(id);
    }
    [HttpPost("Add")]
    public async Task AddReservation([FromBody] Reservation r)
    {
        await _repo.AddReservation(r);
    }

    [HttpPatch("Update")]
    public async Task UpdateReservation([FromBody] Reservation r)
    {
        await _repo.UpdateReservation(r);
    }
    [HttpDelete("Delete")]
    public async Task DeleteReservation(int id)
    {
        await _repo.DeleteReservation(id);
    }
}