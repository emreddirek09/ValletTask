using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vallet.Persistence.Contexts;

namespace Vallet.Persistence.Configurations
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ValletDbContext>(options =>
                options.UseSqlServer(Configuration.ConnectionString));
        }

    }
}
