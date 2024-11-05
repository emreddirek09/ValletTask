using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

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
