using TripApp.Models;
using Zadanie7.Models;

namespace Zadanie7.Repositories;

public interface ITripsRepository
{
    Task<IEnumerable<Trip>> GetTripsAsync();
    Task<bool> TripExistsAsync(int id);
    Task<int> AssignClientToTripAsync(ClientTrip clientTrip);
}