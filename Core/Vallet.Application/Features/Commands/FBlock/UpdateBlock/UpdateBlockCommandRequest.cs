using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FBlock.UpdateBlock
{
    public class UpdateBlockCommandRequest : IRequest<UpdateBlockCommandResponse>
    {
        public string Id { get; set; }

        public string BlockName { get; set; }
        public int BlockNumberOfFloors { get; set; }
    }
}
