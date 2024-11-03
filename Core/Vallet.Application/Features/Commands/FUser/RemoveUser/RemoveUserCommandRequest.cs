using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FUser.RemoveUser
{
    public class RemoveUserCommandRequest:IRequest<RemoveUserCommandResponse>
    {
        public string Id { get; set; }
    }
}
