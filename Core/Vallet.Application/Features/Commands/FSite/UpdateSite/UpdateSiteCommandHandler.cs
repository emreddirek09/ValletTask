using MediatR;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Commands.FSite.UpdateSite
{
    public class UpdateSiteCommandHandler : IRequestHandler<UpdateSiteCommandRequest, UpdateSiteCommandResponse>
    {
        readonly ISiteWriteRepository _writeRepository;
        readonly ISiteReadRepository _readRepository;

        public UpdateSiteCommandHandler(ISiteWriteRepository writeRepository, ISiteReadRepository readRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
        }

        public async Task<UpdateSiteCommandResponse> Handle(UpdateSiteCommandRequest request, CancellationToken cancellationToken)
        {
            Site site = await _readRepository.GetByIdAsync(request.Id);
            site.SiteName = request.SiteName;
            site.SiteIsApartment = request.SiteIsApartment;
            site.SiteAddress = request.SiteAddress;
            await _writeRepository.SaveAsync();

            return new UpdateSiteCommandResponse();
        }
    }
}
