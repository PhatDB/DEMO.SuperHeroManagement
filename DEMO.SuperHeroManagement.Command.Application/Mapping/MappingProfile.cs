using AutoMapper;
using DEMO.SuperHeroManagement.CommandApplication.DTOs.SuperHero;
using DEMO.SuperHeroManagement.CommandDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.CommandApplication.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<SuperHero, SuperHeroDto>().ReverseMap();
            CreateMap<SuperHero, CreateSuperHeroDto>().ReverseMap();
        }
    }
}
