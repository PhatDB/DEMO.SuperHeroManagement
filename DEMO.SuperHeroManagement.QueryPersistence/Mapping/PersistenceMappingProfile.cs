using AutoMapper;
using DEMO.SuperHeroManagement.QueryDomain;
using DEMO.SuperHeroManagement.QueryPersistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHero = DEMO.SuperHeroManagement.QueryDomain.SuperHero;

namespace DEMO.SuperHeroManagement.QueryPersistence.Mapping
{
    public class PersistenceMappingProfile : Profile
    {
        public PersistenceMappingProfile()
        {
            CreateMap<SuperHero, QueryPersistence.Entities.SuperHero>().ReverseMap();
        }
    }
}
