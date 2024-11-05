using MediatR;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FSite.GetAllSite
{
    public class GetAllSiteQueryHandler : IRequestHandler<GetAllSiteQueryRequest, GetAllSiteQueryResponse>
    {
        readonly ISiteReadRepository _siteReadRepository;

        public GetAllSiteQueryHandler(ISiteReadRepository siteReadRepository)
        {
            _siteReadRepository = siteReadRepository;
        }

        public async Task<GetAllSiteQueryResponse> Handle(GetAllSiteQueryRequest request, CancellationToken cancellationToken)
        {
            var _site = _siteReadRepository.GetAll(false);
            return new()
            {
                site = _site,
            };
        }
    }
}
