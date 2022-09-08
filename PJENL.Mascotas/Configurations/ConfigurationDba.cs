using Microsoft.EntityFrameworkCore;
using PJENL.Infraestructure;

namespace PJENL.Mascotas.Configurations
{
    public static class ConfigurationDba
    {
        public static IServiceCollection AddConfigurationDba(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MascotaContext>(c => c.UseSqlServer(configuration.GetConnectionString("Mascotas")));
            return services;
        }
    }
}
