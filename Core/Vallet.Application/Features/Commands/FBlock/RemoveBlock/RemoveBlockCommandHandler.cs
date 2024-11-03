using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;

namespace Vallet.Application.Features.Commands.FBlock.RemoveBlock
{
    public class RemoveBlockCommandHandler : IRequestHandler<RemoveBlockCommandRequest, RemoveBlockCommandResponse>
    {
        readonly IBlokWriteRepository _blokWriteRepository;

        public RemoveBlockCommandHandler(IBlokWriteRepository blokWriteRepository)
        {
            _blokWriteRepository = blokWriteRepository;
        }

        public async Task<RemoveBlockCommandResponse> Handle(RemoveBlockCommandRequest request, CancellationToken cancellationToken)
        {
            await _blokWriteRepository.DeleteAsync(request.Id);
            await _blokWriteRepository.SaveAsync();
            return new RemoveBlockCommandResponse();
        }
    }
}
