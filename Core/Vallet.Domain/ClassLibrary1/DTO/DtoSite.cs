using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Domain.DTO
{
    public class DtoSite
    {
        public class Root
        {
            public List<Site>? data { get; set; }
        }

        public class Site
        {
            public string? siteName { get; set; }
            public string? siteAddress { get; set; }
            public bool siteIsApartment { get; set; }
            public string? id { get; set; }
            public DateTime? createdTime { get; set; } 
        }
    }
}
