using MediatR; 
using Vallet.Application.Repositories;

namespace Vallet.Application.Features.Commands.FApartDebt.CreateApartDebt
{
    public class CreateApartDebtCommandHandler : IRequestHandler<CreateApartDebtCommandRequest, CreateApartDebtCommandResponse>
    {

        readonly IDaireBorcWriteRepository _daireBorcWriteRepository;

        public CreateApartDebtCommandHandler(IDaireBorcWriteRepository daireBorcWriteRepository)
        {
            _daireBorcWriteRepository = daireBorcWriteRepository;
        }

        public async Task<CreateApartDebtCommandResponse> Handle(CreateApartDebtCommandRequest request, CancellationToken cancellationToken)
        {
            await _daireBorcWriteRepository.AddAsync(new()
            {
                DebtAmount = request.DebtAmount,
                DebtDescription = request.DebtDescription,
                DebtCreatedByAdminId = request.DebtCreatedByAdminId,
                UsersId = request.UsersId,
                DaireId = request.DaireId,
                DebtDueDate = DateTime.UtcNow
            });
            await _daireBorcWriteRepository.SaveAsync();

            return new CreateApartDebtCommandResponse();
        }
    }
}
