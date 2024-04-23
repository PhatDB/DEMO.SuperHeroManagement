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
    public class GetSuperHeroDetailRequestHandler : IRequestHandler<GetSuperHeroDetailRequest, SuperHeroDto>
    {
        private readonly ISuperHeroRepository _superHeroRepository;
        private readonly IMapper _mapper;

        public GetSuperHeroDetailRequestHandler(ISuperHeroRepository superHeroRepository, IMapper mapper)
        {
            _superHeroRepository = superHeroRepository;
            _mapper = mapper;
        }
        public async Task<SuperHeroDto> Handle(GetSuperHeroDetailRequest request, CancellationToken cancellationToken)
        {
            var superHero = await _superHeroRepository.Get(request.Id);
            return _mapper.Map<SuperHeroDto>(superHero);
        }
    }
}
