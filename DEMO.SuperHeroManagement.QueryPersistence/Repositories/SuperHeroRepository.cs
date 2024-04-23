using AutoMapper;
using DEMO.SuperHeroManagement.QueryApplication.Contracts.Persistence;
using DEMO.SuperHeroManagement.QueryDomain;
using DEMO.SuperHeroManagement.QueryPersistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryPersistence.Repositories
{
    public class SuperHeroRepository : GenericRepository<SuperHero, QueryPersistence.Entities.SuperHero>, ISuperHeroRepository
    {
        private readonly SuperHeroDbContext _dbContext;

        public SuperHeroRepository(SuperHeroDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
        }
    }
}
