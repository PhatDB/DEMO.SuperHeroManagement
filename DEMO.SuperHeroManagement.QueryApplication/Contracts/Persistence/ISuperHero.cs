using DEMO.SuperHeroManagement.QueryDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryApplication.Contracts.Persistence
{
    public interface ISuperHeroRepository : IGenericRepository<SuperHero>
    {
    }
}
