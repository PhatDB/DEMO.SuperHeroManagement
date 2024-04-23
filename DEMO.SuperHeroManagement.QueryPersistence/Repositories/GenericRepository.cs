using AutoMapper;
using DEMO.SuperHeroManagement.QueryApplication.Contracts.Persistence;
using DEMO.SuperHeroManagement.QueryDomain.Common;
using DEMO.SuperHeroManagement.QueryPersistence.Context;
using DEMO.SuperHeroManagement.QueryPersistence.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryPersistence.Repositories
{
    public class GenericRepository<T,K> : IGenericRepository<T> where T : BaseEntity where K : DataBaseEntity
    {
        private readonly SuperHeroDbContext _superHeroDbContext;
        private readonly IMapper _mapper;

        private DbSet<K> _entities;

        private DbSet<K> Entities
        {
            get
            {
                if(_entities == null)
                {
                    _entities = _superHeroDbContext.Set<K>();
                }
                return _entities;
            }
        }
        public GenericRepository(SuperHeroDbContext superHeroDbContext, IMapper mapper) 
        {
            _superHeroDbContext = superHeroDbContext;
            _mapper = mapper;
        }
        public async Task<T> Get(int id)
        {
            var superHero = await Entities.FindAsync(id);
            return _mapper.Map<T>(superHero);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            var superHeros = await Entities.AsNoTracking().ToListAsync();
            return _mapper.Map<List<T>>(superHeros);
        }
    }
}
