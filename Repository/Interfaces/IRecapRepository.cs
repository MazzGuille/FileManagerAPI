using FileManagerAPI.Models;

namespace FileManagerAPI.Repository.Interfaces
{
    public interface IRecapRepository
    {
        Task<List<HVI>> GetHVI();
    }
}
