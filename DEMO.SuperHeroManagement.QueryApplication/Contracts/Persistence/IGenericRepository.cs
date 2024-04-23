using DEMO.SuperHeroManagement.QueryDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryApplication.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
    }
}
