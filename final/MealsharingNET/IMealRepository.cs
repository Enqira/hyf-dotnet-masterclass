using MealsharingNET.Models;

namespace MealsharingNET;

public interface IMealRepository
{
    Task<IEnumerable<Meal>> ListMeals();

    Task<Meal> GetMeal(int id);
    Task Add(Meal m);

    Task UpdateMeal(Meal meal);

    Task DeleteMeal(int id);
}