using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Commands.FBlock.CreateBlock
{
    public class CreateBlockCommandHandler : IRequestHandler<CreateBlockCommandRequest, CreateBlockCommandResponse>
    {
        readonly IBlokWriteRepository _blokWriteRepository;

        public CreateBlockCommandHandler(IBlokWriteRepository blokWriteRepository)
        {
            _blokWriteRepository = blokWriteRepository;
        }

        public async Task<CreateBlockCommandResponse> Handle(CreateBlockCommandRequest request, CancellationToken cancellationToken)
        {
            await _blokWriteRepository.AddAsync(new()
            {
                BlockName = request.BlockName,
                BlockNumberOfFloors = request.BlockNumberOfFloors,
                SiteId =request.SiteId

            });
            await _blokWriteRepository.SaveAsync();
            return new CreateBlockCommandResponse();
        }
    }
}
