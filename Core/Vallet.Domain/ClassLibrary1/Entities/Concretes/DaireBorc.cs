using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Base;

namespace Vallet.Domain.Entities.Concretes
{
    public class DaireBorc:BaseEntity
    { 
        public decimal DebtAmount { get; set; }
        public DateTime DebtDueDate { get; set; }
        public string DebtCreatedByAdminId { get; set; }
        public string? DebtDescription { get; set; }
        public Guid? DaireId { get; set; }
        public Daire? Daire { get; set; }
        public Guid? UsersId { get; set; }
        public User?  Users { get; set; }
    }
}
