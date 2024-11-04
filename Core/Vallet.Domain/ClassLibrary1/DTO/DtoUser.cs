using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Domain.DTO
{
    public class DtoUser
    {
        public string id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string role { get; set; }
        public object createdBorclar { get; set; }
        public DateTime createdTime { get; set; }
        public object updateTime { get; set; }
    }
}
