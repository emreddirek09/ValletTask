using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Commands.FBlock.CreateBlock
{
    public class CreateBlockCommandRequest : IRequest<CreateBlockCommandResponse>
    {
        public string BlockName { get; set; }
        public int BlockNumberOfFloors { get; set; }
        public Guid? SiteId { get; set; }
    }
}
