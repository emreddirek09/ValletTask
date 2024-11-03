using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Queries.FApart.GetByIdApart
{
    public class GetByIdApartQueryRequest:IRequest<GetByIdApartQueryResponse>
    {
        public string Id { get; set; }
    }
}
