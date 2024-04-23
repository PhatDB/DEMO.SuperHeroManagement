using AutoMapper;
using DEMO.SuperHeroManagement.QueryApplication.Contracts.Persistence;
using DEMO.SuperHeroManagement.QueryApplication.DTOs.SuperHero;
using DEMO.SuperHeroManagement.QueryApplication.Queries.SuperHeroQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryApplication.Handlers.SuperHeroHandlers
{
    public class GetSuperHeroListRequestHandler : IRequestHandler<GetSuperHeroListRequest, List<SuperHeroDto>>
    {
        private readonly ISuperHeroRepository _superHeroRepository;
        private readonly IMapper _mapper;

        public GetSuperHeroListRequestHandler(ISuperHeroRepository superHeroRepository, IMapper mapper) 
        {
            _superHeroRepository = superHeroRepository;
            _mapper = mapper;
        }
        public async Task<List<SuperHeroDto>> Handle(GetSuperHeroListRequest request, CancellationToken cancellationToken)
        {
            var superHero = await _superHeroRepository.GetAll();
            return _mapper.Map<List<SuperHeroDto>>(superHero);
        }
    }
}
