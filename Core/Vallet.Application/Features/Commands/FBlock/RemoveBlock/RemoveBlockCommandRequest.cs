using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FBlock.RemoveBlock
{
    public class RemoveBlockCommandRequest : IRequest<RemoveBlockCommandResponse>
    {
        public string Id { get; set; }
    }
}
