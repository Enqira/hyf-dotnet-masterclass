using MealsharingNET.Models;

namespace MealsharingNET;

public interface IMealRepository
{
    IEnumerable<Meal> ListMeals();
    void Add(Meal m);

    Meal GetMeal(int id);
}