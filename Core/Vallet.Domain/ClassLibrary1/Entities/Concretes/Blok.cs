using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Base;

namespace Vallet.Domain.Entities.Concretes
{
    public class Blok:BaseEntity
    { 
        public string? BlockName { get; set; }
        public int BlockNumberOfFloors { get; set; } 
        public ICollection<Daire>? Daires { get; set; }
    }
}
