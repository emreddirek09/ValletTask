using MediatR; 

namespace Vallet.Application.Features.Commands.FApartDebt.CreateApartDebt
{
    public class CreateApartDebtCommandRequest:IRequest<CreateApartDebtCommandResponse>
    {
        public decimal DebtAmount { get; set; }
        public string DebtCreatedByAdminId { get; set; }
        public string? DebtDescription { get; set; }
        public Guid? DaireId { get; set; }
        public Guid? UsersId { get; set; }
    }
}
