using DEMO.SuperHeroManagement.CommandDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.CommandApplication.Contracts.Persistence
{
    public interface ISuperHeroRepository : IGenericRepository<SuperHero>
    {
    }
}
