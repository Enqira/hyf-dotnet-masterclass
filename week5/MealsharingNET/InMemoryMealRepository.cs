// using MealsharingNET.Models;

// namespace MealsharingNET;

// public class InMemoryMealRepository : IMealRepository
// {
//     private List<Meal> Meals { get; set; } = new List<Meal>(){
//         new Meal()
//         {
//             ID=1,
//             Title="Paella",
//             Description="this is a description",
//             Price= 99,
//             Location="CPH",
//             When= DateTime.Now,
//             MaxReservations= 3
//         },
//         new Meal()
//         {
//             ID=2,
//             Title="Tortilla",
//             Description="Spanish Tortilla",
//             Price= 30,
//             Location="Barcelona",
//             When= DateTime.Now,
//             MaxReservations= 10,
//             CreatedDate= DateTime.Now
//         }

//     };

//     public IEnumerable<Meal> ListMeals()
//     {
//         return Meals;
//     }
//     public void Add(Meal m)
//     {
//         Meals.Add(m);
//     }
//     public Meal GetMeal(int id)
//     {
//         return Meals.FirstOrDefault(m => m.ID == id);
//     }
// }


