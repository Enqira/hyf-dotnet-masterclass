using MealsharingNET.Models;

namespace MealsharingNET;

public class InMemoryReservationRepository : IReservationRepository
{
    private List<Reservation> Reservations { get; set; } = new List<Reservation>(){
        new Reservation()
        {
            ID=1,
            NumberOfGuests=10,
            MealID=2,
            CreatedDate= DateTime.Now,
            ContactPhoneNumber= "10101010",
            ContactName= "Enqiar",
            ContactEmail="enqira@gmail.com"
        },
        new Reservation()
        {
            ID=2,
            NumberOfGuests=100,
            MealID=1,
            CreatedDate= DateTime.Now,
            ContactPhoneNumber= "20202020",
            ContactName= "Benjamin",
            ContactEmail="Benjamin@gmail.com"
        }
    };

    public IEnumerable<Reservation> ListReservations()
    {
        return Reservations;
    }
    public void Add(Reservation r)
    {
        Reservations.Add(r);
    }
    public IEnumerable<Reservation> GetReservation(int id)
    {
        return Reservations.Where(r => r.ID == id);
    }

    public IEnumerable<Reservation> MealReservations(int id)
    {
        return Reservations.Where(r => r.MealID == id);
    }
}


