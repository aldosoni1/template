using PJENL.Application.Services.Mascota;

namespace PJENL.Mascotas.Configurations
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddConfigurationServices(this IServiceCollection services)
        {
            services.AddScoped<IMascotaService, MascotaService>();
            return services;
        }
    }
}
