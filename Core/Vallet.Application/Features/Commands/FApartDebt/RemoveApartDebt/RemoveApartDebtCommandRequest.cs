using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FApartDebt.RemoveApartDebt
{
    public class RemoveApartDebtCommandRequest:IRequest<RemoveApartDebtCommandResponse>
    {
        public string Id { get; set; }
    }
}
