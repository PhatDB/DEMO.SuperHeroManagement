using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryPersistence.Entities.Common
{
    public abstract class DataBaseEntity
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
