using DEMO.SuperHeroManagement.QueryApplication.Contracts.Persistence;
using DEMO.SuperHeroManagement.QueryPersistence.Context;
using DEMO.SuperHeroManagement.QueryPersistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryPersistence.Extentions
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<SuperHeroDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("SuperHeroConnectionString")));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
           //ervices.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ISuperHeroRepository, SuperHeroRepository>();

            return services;
        }
    }
}
