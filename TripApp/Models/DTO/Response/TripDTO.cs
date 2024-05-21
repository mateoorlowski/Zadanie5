namespace Zadanie7.Models.DTOs.Response;

public class TripDto
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly DateFrom { get; set; }

    public DateOnly DateTo { get; set; }

    public int MaxPeople { get; set; }

    public IEnumerable<CountryDto> Countries { get; set; } = null!;

    public IEnumerable<ClientDto> Clients { get; set; } = null!;
}