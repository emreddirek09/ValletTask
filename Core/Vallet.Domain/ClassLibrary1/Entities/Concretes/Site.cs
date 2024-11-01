using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Base;

namespace Vallet.Domain.Entities.Concretes
{
    public class Site: BaseEntity
    { 
        public string? SiteName { get; set; }
        public string? SiteAddress { get; set; }
        public bool SiteIsApartment { get; set; }
        public ICollection<Blok>? Blocks { get; set; }
    }
}
