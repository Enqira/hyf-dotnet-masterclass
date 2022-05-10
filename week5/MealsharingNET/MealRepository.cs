using MealsharingNET.Models;
using Dapper;
using MySql.Data.MySqlClient;
//using System.Data.SqlClient.SqlConnection;


namespace MealsharingNET;

public class MealRepository : IMealRepository
{

    public async Task<IEnumerable<Meal>> ListMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var Meals = await connection.QueryAsync<Meal>("SELECT * FROM Meals");
        //var Meals = await connection.QueryFirstAsync<Meal>("SELECT * FROM Meals");
        return Meals;
    }

    public async Task Add(Meal meal)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("INSERT INTO Meals VALUES (@ID, @Title, @Description, @Location, @When, @Price, @MaxReservations)", meal);

    }
    public async Task<Meal> GetMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var Meals = await connection.QueryFirstAsync<Meal>("SELECT * FROM Meals WHERE ID = @id", new { id = id });

        return Meals;

    }

    public async Task UpdateMeal(Meal meal)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("UPDATE Meals SET title=@Title, Description=@Description, Location=@Location, `When`=@When, Price=@Price, MaxReservations=@MaxReservations WHERE ID = @id ", meal);

    }

    public async Task DeleteMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("DELETE FROM Meals WHERE id=@id", new { id = id });
    }
}


