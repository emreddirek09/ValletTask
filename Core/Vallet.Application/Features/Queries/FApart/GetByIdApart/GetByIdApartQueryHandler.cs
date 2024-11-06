using MediatR; 
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FApart.GetByIdApart
{
    public class GetByIdApartQueryHandler : IRequestHandler<GetByIdApartQueryRequest, GetByIdApartQueryResponse>
    {
        readonly IDaireReadRepository _daireReadRepository;

        public GetByIdApartQueryHandler(IDaireReadRepository daireReadRepository)
        {
            _daireReadRepository = daireReadRepository;
        }

        public async Task<GetByIdApartQueryResponse> Handle(GetByIdApartQueryRequest request, CancellationToken cancellationToken)
        {
            Daire daire = await _daireReadRepository.GetByIdAsync(request.Id);
            return new GetByIdApartQueryResponse()
            {
                Id = daire.Id.ToString(),
                Block = daire.Block,
                BlockId = daire.BlockId,
                DaireApartmentNumber = daire.DaireApartmentNumber,
                DaireBorcs = daire.DaireBorcs,
                DaireFloorNumber = daire.DaireFloorNumber,
                Users = daire.Users,
                UsersId = daire.UsersId,
            };
        }
    }
}
