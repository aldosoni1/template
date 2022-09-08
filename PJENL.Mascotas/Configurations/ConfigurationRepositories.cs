using PJENL.Domain.Repositories;
using PJENL.Infraestructure.Repositories;

namespace PJENL.Mascotas.Configurations
{
    public static class ConfigurationRepositories
    {
        public static IServiceCollection AddConfigurationRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMascotaRepository, MascotaRepository>();
            return services;
        }
    }
}
