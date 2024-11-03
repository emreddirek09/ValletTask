using MediatR;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FSite.GetByIdSite
{
    public class GetByIdSiteQueryHandler : IRequestHandler<GetByIdSiteQueryRequest, GetByIdSiteQueryResponse>
    {
        readonly ISiteReadRepository _siteReadRepository;

        public GetByIdSiteQueryHandler(ISiteReadRepository siteReadRepository)
        {
            _siteReadRepository = siteReadRepository;
        }

        public async Task<GetByIdSiteQueryResponse> Handle(GetByIdSiteQueryRequest request, CancellationToken cancellationToken)
        {

            Site site = await _siteReadRepository.GetByIdAsync(request.Id,false);
            return new()
            {
                Id = site.Id.ToString(),
                SiteAddress = site.SiteAddress,
                SiteName = site.SiteName,
                SiteIsApartment = site.SiteIsApartment,
            };
        }
    }
} 