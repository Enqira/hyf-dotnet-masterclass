using MealsharingNET.Models;

namespace MealsharingNET;

public interface IReservationRepository
{
    Task<IEnumerable<Reservation>> ListReservations();
    Task<List<Reservation>> GetMealReservations(int mealId);
    Task AddReservation(Reservation r);
    Task UpdateReservation(Reservation r);
    Task DeleteReservation(int id);
}