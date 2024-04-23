using DEMO.SuperHeroManagement.QueryApplication.DTOs.SuperHero;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryApplication.Queries.SuperHeroQueries
{
    public class GetSuperHeroDetailRequest : IRequest<SuperHeroDto>
    {
        public int Id { get; set; }
    }
}
