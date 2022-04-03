using MySql.Data.MySqlClient;
using Dapper;
using MealsharingNET;
using MealsharingNET.Models;

public class ReservationRepository : IReservationRepository
{

    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Reservation>("SELECT * FROM reservations");
        return meals;
    }
    public async Task AddReservation(Reservation r)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("INSERT INTO reservations VALUES (@ID, @MealID, @NumberOfGuests, @createdDate, @ContactPhoneNumber, @ContactName, @ContactEmail)", r);
    }

    public async Task<List<Reservation>> GetMealReservations(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryAsync<Reservation>("SELECT * FROM reservations WHERE MealID=@mealId", new { mealId = id });
        return meal.ToList();
    }
    public async Task UpdateReservation(Reservation r)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("UPDATE reservations SET id=@ID, MealID=@MealID, ContactName=@ContactName, ContactEmail=@ContactEmail, NumberOfGuests=@NumberOfGuests, CreatedDate=@CreatedDate, ContactPhoneNumber=@ContactPhoneNumber WHERE id = @ID", r);
    }
    public async Task DeleteReservation(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync(@"DELETE FROM reservations WHERE Id = @Id", new { Id = id });
    }
}