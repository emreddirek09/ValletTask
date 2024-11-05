using MediatR;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FBlock.GetAllBlock
{
    public class GetAllBlockQueryHandler : IRequestHandler<GetAllBlockQueryRequest, GetAllBlockQueryResponse>
    {
        readonly IBlokReadRepository _blokReadRepository;

        public GetAllBlockQueryHandler(IBlokReadRepository blokReadRepository)
        {
            _blokReadRepository = blokReadRepository;
        }

        public async Task<GetAllBlockQueryResponse> Handle(GetAllBlockQueryRequest request, CancellationToken cancellationToken)
        {
            var blok = _blokReadRepository.GetAll(false);
            return new()
            {
                Data = blok

            };

        }

    }
}
