using consulting_information_rickmorty.api.Service;
using consulting_information_rickmorty.api.Service.Interface;

namespace consulting_information_rickmorty.api.DependencyInjection
{
    public static class DependencyInjectionRegistry
    {
        public static void ResolveDependencies(this IServiceCollection service)
        {
            service.AddScoped<IEpisodeService, EpisodeService>();
            service.AddScoped<ICharacterService, CharacterService>();
            service.AddScoped<ILocationService, LocationService>();
        }
    }
}
