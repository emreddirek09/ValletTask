using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FSite.RemoveSite
{
    public class RemoveSiteCommandRequest : IRequest<RemoveSiteCommandResponse>
    {
        public string Id { get; set; }
    }
}
