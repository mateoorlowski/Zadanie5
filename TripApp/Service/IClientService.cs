namespace Zadanie7.Services;

public interface IClientService
{
    Task<int> DeleteClientAsync(int id);
}