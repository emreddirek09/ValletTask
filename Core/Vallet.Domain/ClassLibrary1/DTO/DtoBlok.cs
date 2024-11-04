using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Domain.DTO
{
    public class DtoBlok
    {
        public  string Id { get; set; }
        public string? BlockName { get; set; }
        public int BlockNumberOfFloors { get; set; }
    }
}
