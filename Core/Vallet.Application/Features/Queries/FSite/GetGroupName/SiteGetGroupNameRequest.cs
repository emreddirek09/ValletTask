using MediatR; 
using Vallet.Domain.DTO;

namespace Vallet.Application.Features.Queries.FSite.GetGroupName
{
    public class SiteGetGroupNameRequest:IRequest<SiteGetGroupNameResponse>
    {
    }
}
