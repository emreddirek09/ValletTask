using MediatR; 
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FApartDebt.GetByIdApartDebt
{
    public class GetByIdApartDebtQueryHandler : IRequestHandler<GetByIdApartDebtQueryRequest, GetByIdApartDebtQueryResponse>
    {
        readonly IDaireBorcReadRepository _daireBorcReadRepository;

        public GetByIdApartDebtQueryHandler(IDaireBorcReadRepository daireBorcReadRepository)
        {
            _daireBorcReadRepository = daireBorcReadRepository;
        }

        public async Task<GetByIdApartDebtQueryResponse> Handle(GetByIdApartDebtQueryRequest request, CancellationToken cancellationToken)
        {
            DaireBorc daireBorc = await _daireBorcReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Daire = daireBorc.Daire,
                DaireId = daireBorc.DaireId,
                DebtAmount = daireBorc.DebtAmount,
                DebtCreatedByAdminId = daireBorc.DebtCreatedByAdminId,
                DebtDescription = daireBorc.DebtDescription,
                DebtDueDate = daireBorc.DebtDueDate,
                Users = daireBorc.Users,
                UsersId = daireBorc.UsersId
            };
        }
    }
}
