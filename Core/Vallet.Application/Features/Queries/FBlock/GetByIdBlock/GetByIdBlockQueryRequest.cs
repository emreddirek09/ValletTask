using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Queries.FBlock.GetByIdBlock
{
    public class GetByIdBlockQueryRequest : IRequest<GetByIdBlockQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
