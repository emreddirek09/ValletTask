using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Queries.FApartDebt.GetByIdApartDebt
{
    public class GetByIdApartDebtQueryRequest:IRequest<GetByIdApartDebtQueryResponse>
    {
        public string Id { get; set; }
    }
}
