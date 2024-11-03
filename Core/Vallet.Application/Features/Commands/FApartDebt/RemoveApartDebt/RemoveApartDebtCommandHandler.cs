using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
