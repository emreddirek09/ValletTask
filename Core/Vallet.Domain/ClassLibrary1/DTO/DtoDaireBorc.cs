using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Domain.DTO
{
    public class DtoDaireBorc
    {
        public string Id { get; set; }
        public decimal DebtAmount { get; set; }
        public DateTime DebtDueDate { get; set; }
        public string DebtCreatedByAdminId { get; set; }
        public string? DebtDescription { get; set; }
    }
}
