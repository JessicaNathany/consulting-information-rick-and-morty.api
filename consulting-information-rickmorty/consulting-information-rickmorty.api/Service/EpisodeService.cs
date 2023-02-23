using consulting_information_rickmorty.api.Models;
using consulting_information_rickmorty.api.Repository.Interface;
using consulting_information_rickmorty.api.Service.Interface;

namespace consulting_information_rickmorty.api.Service
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IEpisodeRepository _episodeRepository;
        public EpisodeService(IEpisodeRepository episodeRepository)
        {
            _episodeRepository = episodeRepository;
        }

        public Task<IEnumerable<Episode>> GetAllEpisodes()
        {
            throw new NotImplementedException();
        }

        public Task<Episode> GetEpisodeById(int id)
        {
           throw new NotImplementedException();

           
        }
    }
}
