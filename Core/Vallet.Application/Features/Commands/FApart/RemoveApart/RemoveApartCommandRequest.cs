using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FApart.RemoveApart
{
    public class RemoveApartCommandRequest:IRequest<RemoveApartCommandResponse>
    {
        public string Id { get; set; }
    }
}
