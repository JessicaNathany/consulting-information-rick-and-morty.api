using consulting_information_rickmorty.api.Models;
using consulting_information_rickmorty.api.Service.Interface;

namespace consulting_information_rickmorty.api.Service
{
    public class EpisodeService : IEpisodeService
    {
        public Task<IEnumerable<Episode>> GetAllEpisodes()
        {
            throw new NotImplementedException();
        }
    }
}
