using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Features.Commands.FBlock.RemoveBlock;
using Vallet.Application.Repositories;

namespace Vallet.Application.Features.Commands.FApart.RemoveApart
{
    public class RemoveApartCommandHandler : IRequestHandler<RemoveApartCommandRequest, RemoveApartCommandResponse>
    {
        readonly IDaireWriteRepository _daireWriteRepository;

        public RemoveApartCommandHandler(IDaireWriteRepository daireWriteRepository)
        {
            _daireWriteRepository = daireWriteRepository;
        }

        public async Task<RemoveApartCommandResponse> Handle(RemoveApartCommandRequest request, CancellationToken cancellationToken)
        { 
            await _daireWriteRepository.DeleteAsync(request.Id);
            await _daireWriteRepository.SaveAsync();
            return new RemoveApartCommandResponse();
        }
    }
}
