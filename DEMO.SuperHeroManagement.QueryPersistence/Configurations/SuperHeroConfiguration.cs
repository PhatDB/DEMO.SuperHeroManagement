using DEMO.SuperHeroManagement.QueryPersistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryPersistence.Configurations
{
    public class SuperHeroConfiguration :IEntityTypeConfiguration<SuperHero>
    {
        public void Configure(EntityTypeBuilder<SuperHero> builder)
        {
            builder.HasData(
                new SuperHero
                {
                    Id = 1,
                    Name = "Wolverine",
                    FistName = "Howlett",
                    LastName = "James",
                    Place = "America"
                },
                new SuperHero
                {
                    Id = 2,
                    Name = "DeadPool",
                    FistName = "Wilson",
                    LastName = "Wade",
                    Place = "America"
                }
                );
        }
    }
}
