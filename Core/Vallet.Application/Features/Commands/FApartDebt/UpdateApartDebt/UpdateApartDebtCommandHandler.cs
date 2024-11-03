using MediatR;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Commands.FApartDebt.UpdateApartDebt
{
    public class UpdateApartDebtCommandHandler : IRequestHandler<UpdateApartDebtCommandRequest, UpdateApartDebtCommandResponse>
    {
        readonly IDaireWriteRepository _daireWriteRepository;
        readonly IDaireBorcReadRepository _daireBorcReadRepository;

        public UpdateApartDebtCommandHandler(IDaireWriteRepository daireWriteRepository, IDaireBorcReadRepository daireBorcReadRepository)
        {
            _daireWriteRepository = daireWriteRepository;
            _daireBorcReadRepository = daireBorcReadRepository;
        }
        public async Task<UpdateApartDebtCommandResponse> Handle(UpdateApartDebtCommandRequest request, CancellationToken cancellationToken)
        {
            DaireBorc daireBorc = await _daireBorcReadRepository.GetByIdAsync(request.Id);
            daireBorc.DebtDescription = request.DebtDescription;
            daireBorc.DebtAmount = request.DebtAmount;
            await _daireWriteRepository.SaveAsync();
            return new UpdateApartDebtCommandResponse();
        }
    }
}
