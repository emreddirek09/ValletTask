using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vallet.Application.Repositories;
using Vallet.Persistence.Contexts;
using Vallet.Persistence.Repositories;
using Vallet.UI.Helpers.ClientHelper;

namespace Vallet.Persistence.Configurations
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ValletDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IBlokReadRepository, BlokReadRepository>();
            services.AddScoped<IBlokWriteRepository, BlokWriteRepository>();
            services.AddScoped<IDaireReadRepository, DaireReadRepository>();
            services.AddScoped<IDaireWriteRepository, DaireWriteRepository>();
            services.AddScoped<IDaireBorcReadRepository, DaireBorcReadRepository>();
            services.AddScoped<IDaireBorcWriteRepository, DaireBorcWriteRepository>();
            services.AddScoped<ISiteReadRepository, SiteReadRepository>();
            services.AddScoped<ISiteWriteRepository, SiteWriteRepository>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
        }

    }
}
