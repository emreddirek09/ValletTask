using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FApartDebt.UpdateApartDebt
{
    public class UpdateApartDebtCommandRequest:IRequest<UpdateApartDebtCommandResponse>
    {
        public string Id { get; set; }
        public decimal DebtAmount { get; set; }
        public string? DebtDescription { get; set; }
    }
}
