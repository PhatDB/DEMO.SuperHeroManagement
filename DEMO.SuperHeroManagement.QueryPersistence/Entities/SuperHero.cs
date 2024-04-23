using DEMO.SuperHeroManagement.QueryPersistence.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryPersistence.Entities
{
    public class SuperHero : DataBaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string FistName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;

    }
}
