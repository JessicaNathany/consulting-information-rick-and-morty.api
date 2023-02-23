using consulting_information_rickmorty.api.Models;

namespace consulting_information_rickmorty.api.Service.Interface
{
    public interface IEpisodeService
    {
        Task<IEnumerable<Episode>> GetAllEpisodes();

        Task<Episode> GetEpisodeById(int id);
    }
}
