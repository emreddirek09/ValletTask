using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Base;

namespace Vallet.Domain.Entities.Concretes
{
    public class User:BaseEntity
    {  
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; } 
        public ICollection<DaireBorc>? CreatedBorclar { get; set; }
    }
}
