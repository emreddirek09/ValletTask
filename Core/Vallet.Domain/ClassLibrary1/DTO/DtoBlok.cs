using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Domain.DTO
{
    public class DtoBlok
    {
        public  string id { get; set; }
        public string? blockName { get; set; }
        public int blockNumberOfFloors { get; set; }
        public string? siteId { get; set; }


    }
}
