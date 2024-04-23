using DEMO.SuperHeroManagement.QueryDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryDomain
{
    public class SuperHero : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string FistName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}
