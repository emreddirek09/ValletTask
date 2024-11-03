using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Base;

namespace Vallet.Domain.Entities.Concretes
{
    public class Daire:BaseEntity
    { 
        public int DaireFloorNumber { get; set; }
        public int DaireApartmentNumber { get; set; } 
        public Guid? UsersId { get; set; }
        public User? Users { get; set; }
        public Guid? BlockId { get; set; }
        public Blok? Block { get; set; }
        public ICollection<DaireBorc>? DaireBorcs { get; set; }
    }
}
