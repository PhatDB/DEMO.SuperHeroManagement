using AutoMapper;
using DEMO.SuperHeroManagement.QueryApplication.DTOs.SuperHero;
using DEMO.SuperHeroManagement.QueryDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryApplication.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<SuperHero, SuperHeroDto>().ReverseMap();
        }
    }
}
