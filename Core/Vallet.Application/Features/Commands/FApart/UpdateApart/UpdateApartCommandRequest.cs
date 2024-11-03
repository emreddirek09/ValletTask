using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Commands.FApart.UpdateApart
{
    public class UpdateApartCommandRequest : IRequest<UpdateApartCommandResponse>
    {
        public string Id { get; set; }
        public int DaireFloorNumber { get; set; }
        public int DaireApartmentNumber { get; set; }
    }
}
