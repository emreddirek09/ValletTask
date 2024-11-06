using MediatR; 
using Vallet.Application.Repositories;

namespace Vallet.Application.Features.Commands.FApartDebt.RemoveApartDebt
{
    public class RemoveApartDebtCommandHandler : IRequestHandler<RemoveApartDebtCommandRequest, RemoveApartDebtCommandResponse>
    {
        readonly IDaireBorcWriteRepository _daireBorcWriteRepository;

        public RemoveApartDebtCommandHandler(IDaireBorcWriteRepository daireBorcWriteRepository)
        {
            _daireBorcWriteRepository = daireBorcWriteRepository;
        }
        public async Task<RemoveApartDebtCommandResponse> Handle(RemoveApartDebtCommandRequest request, CancellationToken cancellationToken)
        {
            await _daireBorcWriteRepository.DeleteAsync(request.Id);
            await _daireBorcWriteRepository.SaveAsync();
            return new RemoveApartDebtCommandResponse();
        }
    }
}
