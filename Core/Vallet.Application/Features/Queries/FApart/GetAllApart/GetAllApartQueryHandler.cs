using MediatR; 
using Vallet.Application.Repositories; 

namespace Vallet.Application.Features.Queries.FApart.GetAllApart
{
    public class GetAllApartQueryHandler : IRequestHandler<GetAllApartQueryRequest, GetAllApartQueryResponse>
    {
        readonly IDaireReadRepository _daireReadRepository;

        public GetAllApartQueryHandler(IDaireReadRepository daireReadRepository)
        {
            _daireReadRepository = daireReadRepository;
        }

        public async Task<GetAllApartQueryResponse> Handle(GetAllApartQueryRequest request, CancellationToken cancellationToken)
        {
           var response = _daireReadRepository.GetAll();

            return new()
            {
                Data = response
            };
        }
    }
}
