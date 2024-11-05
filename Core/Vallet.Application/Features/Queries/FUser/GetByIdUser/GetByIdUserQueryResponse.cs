using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.Features.Queries.FUser.GetByIdUser
{
    public class GetByIdUserQueryResponse
    { 

        public string id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string role { get; set; }
        public DateTime creteTime { get; set; }
        public DateTime updateTime { get; set; }


    }
}
