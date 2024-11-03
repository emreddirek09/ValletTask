using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Application.Features.Queries.FApartDebt.GetByIdApartDebt
{
    public class GetByIdApartDebtQueryResponse
    {
        public string Id { get; set; }
        public decimal DebtAmount { get; set; }
        public DateTime DebtDueDate { get; set; }
        public string DebtCreatedByAdminId { get; set; }
        public string? DebtDescription { get; set; }
        public Guid? DaireId { get; set; }
        public Daire? Daire { get; set; }
        public Guid? UsersId { get; set; }
        public User? Users { get; set; }
        //  public object GetByIdApartDebt { get; set; }

    }
}
