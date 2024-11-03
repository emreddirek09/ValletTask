using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Queries.FSite.GetByIdSite
{
    public class GetByIdSiteQueryRequest : IRequest<GetByIdSiteQueryResponse>
    {
        public string Id { get; set; }
    }
}
