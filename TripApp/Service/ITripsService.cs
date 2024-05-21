using Zadanie7.Models.DTOs.Request;
using Zadanie7.Models.DTOs.Response;

namespace Zadanie7.Services;

public interface ITripsService
{
    Task<IEnumerable<TripDto>> GetTripsAsync();
    Task<int> AssignClientToTripAsync(ClientAssignmentDTO clientAssignmentDTO);
}