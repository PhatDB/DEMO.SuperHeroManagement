using DEMO.SuperHeroManagement.QueryApplication.Queries.SuperHeroQueries;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.QueryPresentation.Endpoints.SuperHero
{
    public static class SuperHeroEndpointsMap
    {
        public static IEndpointRouteBuilder MapSuperHeroEndpoints(this IEndpointRouteBuilder app)
        {
            var superHero = app.MapGroup("api/superhero");

            superHero.MapGet("/", async (IMediator mediator) =>
            {
                var superHeros = await mediator.Send(new GetSuperHeroListRequest());
                return Results.Ok(superHeros);
            });
            superHero.MapGet("/{id:int}", async (IMediator mediator,int id) =>
            {
                var superHeros = await mediator.Send(new GetSuperHeroDetailRequest { Id = id });
                return Results.Ok(superHeros);
            });
            return app;
        }
    }
}
