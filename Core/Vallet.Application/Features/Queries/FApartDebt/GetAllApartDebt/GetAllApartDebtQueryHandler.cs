using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Features.Queries.FApart.GetAllApart;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

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
                ApartDebt = response
            };
        }
    }
}
