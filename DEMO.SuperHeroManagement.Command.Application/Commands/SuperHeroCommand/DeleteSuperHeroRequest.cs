using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SuperHeroManagement.CommandApplication.Commands.SuperHeroCommand
{
    public class DeleteSuperHeroRequest : IRequest
    {
        public int Id { get; set; }
    }
}
