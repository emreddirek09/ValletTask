using MediatR; 
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Commands.FApart.UpdateApart
{
    public class UpdateApartCommandHandler : IRequestHandler<UpdateApartCommandRequest, UpdateApartCommandResponse>
    {
        readonly IDaireWriteRepository _daireWriteRepository;
        readonly IDaireReadRepository _daireReadRepository;

        public UpdateApartCommandHandler(IDaireWriteRepository daireWriteRepository, IDaireReadRepository daireReadRepository)
        {
            _daireWriteRepository = daireWriteRepository;
            _daireReadRepository = daireReadRepository;
        }

        public async Task<UpdateApartCommandResponse> Handle(UpdateApartCommandRequest request, CancellationToken cancellationToken)
        {
            Daire daire = await _daireReadRepository.GetByIdAsync(request.Id);
            daire.DaireFloorNumber = request.DaireFloorNumber;
            daire.DaireApartmentNumber = request.DaireApartmentNumber;
            _daireWriteRepository.SaveAsync();

            return new UpdateApartCommandResponse();
        }
    }
}
