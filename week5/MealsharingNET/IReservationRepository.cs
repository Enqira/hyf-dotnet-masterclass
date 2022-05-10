using MealsharingNET.Models;

namespace MealsharingNET;

public interface IReservationRepository
{
    IEnumerable<Reservation> ListReservations();
    void Add(Reservation r);

    Reservation GetReservation(int id);
    IEnumerable<Reservation> MealReservations(int mealId);
}