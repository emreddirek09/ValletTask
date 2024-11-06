using MediatR;
using Vallet.Application.Repositories; 

namespace Vallet.Application.Features.Queries.FSite.GetGroupName
{
    public class SiteGetGroupNameHandler : IRequestHandler<SiteGetGroupNameRequest, SiteGetGroupNameResponse>
    {
        readonly ISiteReadRepository _siteReadRepository;

        public SiteGetGroupNameHandler(ISiteReadRepository siteReadRepository)
        {
            _siteReadRepository = siteReadRepository;
        }

        public async Task<SiteGetGroupNameResponse> Handle(SiteGetGroupNameRequest request, CancellationToken cancellationToken)
        {

            var _site = _siteReadRepository.table.GroupBy(d => d.SiteName)
                                                        .Select(g => g.FirstOrDefault()).ToList();

            return new()
            {
                Data = _site
            };
        }
    }
}
