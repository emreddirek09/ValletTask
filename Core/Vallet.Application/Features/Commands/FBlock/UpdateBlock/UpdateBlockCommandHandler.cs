using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Features.Commands.FSite.UpdateSite;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Commands.FBlock.UpdateBlock
{
    public class UpdateBlockCommandHandler : IRequestHandler<UpdateBlockCommandRequest, UpdateBlockCommandResponse>
    {
        readonly IBlokReadRepository _blokReadRepository;
        readonly IBlokWriteRepository _blokWriteRepository;

        public UpdateBlockCommandHandler(IBlokReadRepository blokReadRepository, IBlokWriteRepository blokWriteRepository)
        {
            _blokReadRepository = blokReadRepository;
            _blokWriteRepository = blokWriteRepository;
        }

        public async Task<UpdateBlockCommandResponse> Handle(UpdateBlockCommandRequest request, CancellationToken cancellationToken)
        {
            Blok blok = await _blokReadRepository.GetByIdAsync(request.Id);
            blok.BlockName = request.BlockName;
            blok.BlockNumberOfFloors = request.BlockNumberOfFloors;
            await _blokWriteRepository.SaveAsync();

            return new UpdateBlockCommandResponse();
        }
    }
}
