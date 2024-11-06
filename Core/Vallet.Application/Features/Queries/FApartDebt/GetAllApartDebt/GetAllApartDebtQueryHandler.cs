using MediatR; 
using Vallet.Application.Repositories; 

namespace Vallet.Application.Features.Queries.FApartDebt.GetAllApartDebt
{
    public class GetAllApartDebtQueryHandler : IRequestHandler<GetAllApartDebtQueryRequest, GetAllApartDebtQueryResponse>
    {
        readonly IDaireBorcReadRepository _daireBorcReadRepository;

        public GetAllApartDebtQueryHandler(IDaireBorcReadRepository  daireBorcReadRepository )
        {
            _daireBorcReadRepository = daireBorcReadRepository;
        }
         
        public async Task<GetAllApartDebtQueryResponse> Handle(GetAllApartDebtQueryRequest request, CancellationToken cancellationToken)
        {
            var response =_daireBorcReadRepository.GetAll();

            return new()
            {
                Data = response
            };
        }
    }
}
