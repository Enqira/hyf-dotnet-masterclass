using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("api/meals")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("")]
    public async Task<ActionResult<IEnumerable<Meal>>> ListAllMeals()
    {
        var response = await _repo.ListMeals();
        return new OkObjectResult(response);
    }
    [HttpPost("")]
    public async Task AddMeal([FromBody] Meal m)
    {
        await _repo.AddMeal(m);
    }

    [HttpGet("{id}")]
    public async Task<Meal> GetMeal(int id)
    {
        return await _repo.GetMeal(id);
    }

    [HttpPut("")]
    public async Task UpdateMeal([FromBody] Meal m)
    {
        await _repo.UpdateMeal(m);
    }

    [HttpDelete("")]
    public async Task DeleteMeal(int id)
    {
        await _repo.DeleteMeal(id);
    }
}