using MediatR;

namespace Vallet.Application.Features.Commands.FApart.CreateApart
{
    public class CreateApartCommandRequest : IRequest<CreateApartCommandResponse>
    {
        public int DaireFloorNumber { get; set; }
        public int DaireApartmentNumber { get; set; }
        public string? UsersId { get; set; }
        public string? BlockId { get; set; }
    }
}
