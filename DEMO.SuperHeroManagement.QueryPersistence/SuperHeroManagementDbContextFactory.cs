using DEMO.SuperHeroManagement.QueryPersistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryPersistence
{
    public class SuperHeroManagementDbContextFactory : IDesignTimeDbContextFactory<SuperHeroDbContext>
    {
        public SuperHeroDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var builder = new DbContextOptionsBuilder<SuperHeroDbContext>();
            var connectionString = configuration.GetConnectionString("SuperHeroConnectionString");

            builder.UseSqlServer(connectionString);
            return new SuperHeroDbContext(builder.Options);
        }
    }
}
