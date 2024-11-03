using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallet.Application.ViewModels
{
    public class UserCreateModel
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; } 
    }
}
