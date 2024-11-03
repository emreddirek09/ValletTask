using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;

namespace Vallet.Application.Features.Commands.FSite.CreateSite
{
    public class CreateSiteCommandHandler : IRequestHandler<CreateSiteCommandRequest, CreateSiteCommandResponse>
    {
        readonly ISiteWriteRepository _siteWriteRepository;

        public CreateSiteCommandHandler(ISiteWriteRepository siteWriteRepository)
        {
            _siteWriteRepository = siteWriteRepository;
        }

        public async Task<CreateSiteCommandResponse> Handle(CreateSiteCommandRequest request, CancellationToken cancellationToken)
        {
            await _siteWriteRepository.AddAsync(new()
            {
                SiteName = request.SiteName,
                SiteAddress = request.SiteAddress,
                SiteIsApartment = request.SiteIsApartment
            });
            await _siteWriteRepository.SaveAsync();
            return new CreateSiteCommandResponse();
        }
    }
}
