using MediatR; 
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FBlock.GetByIdBlock
{
    public class GetByIdBlockQueryHandler : IRequestHandler<GetByIdBlockQueryRequest, GetByIdBlockQueryResponse>
    {
        readonly IBlokReadRepository _blokReadRepository;

        public GetByIdBlockQueryHandler(IBlokReadRepository blokReadRepository)
        {
            _blokReadRepository = blokReadRepository;
        }

        public async Task<GetByIdBlockQueryResponse> Handle(GetByIdBlockQueryRequest request, CancellationToken cancellationToken)
        {
            Blok blok = await _blokReadRepository.GetByIdAsync(request.Id.ToString(),false);
            return new()
            {
                BlockName = blok.BlockName,
                BlockNumberOfFloors = blok.BlockNumberOfFloors,
                Daires = blok.Daires,
                SiteId = (Guid)blok.SiteId

            };
        }
    }
}
