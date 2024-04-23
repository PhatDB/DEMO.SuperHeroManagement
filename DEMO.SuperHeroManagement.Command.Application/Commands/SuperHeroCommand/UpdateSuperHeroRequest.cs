using DEMO.SuperHeroManagement.CommandApplication.DTOs.SuperHero;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.CommandApplication.Commands.SuperHeroCommand
{
    public class UpdateSuperHeroRequest : IRequest
    {
        public SuperHeroDto SuperHero { get; set; }
    }
}
