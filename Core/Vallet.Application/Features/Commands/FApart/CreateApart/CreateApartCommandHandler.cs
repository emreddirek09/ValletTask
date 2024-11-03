using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;

namespace Vallet.Application.Features.Commands.FApart.CreateApart
{
    public class CreateApartCommandHandler : IRequestHandler<CreateApartCommandRequest, CreateApartCommandResponse>
    {
        readonly IDaireWriteRepository _daireWriteRepository;

        public CreateApartCommandHandler(IDaireWriteRepository daireWriteRepository)
        {
            _daireWriteRepository = daireWriteRepository;
        }

        public async Task<CreateApartCommandResponse> Handle(CreateApartCommandRequest request, CancellationToken cancellationToken)
        {
            await _daireWriteRepository.AddAsync(new()
            {
                DaireApartmentNumber = request.DaireApartmentNumber,
                DaireFloorNumber = request.DaireFloorNumber,
                BlockId =Guid.Parse(request.BlockId),
                UsersId = Guid.Parse(request.UsersId)
            });
            await _daireWriteRepository.SaveAsync();
            return new CreateApartCommandResponse();
        }
    }
}
