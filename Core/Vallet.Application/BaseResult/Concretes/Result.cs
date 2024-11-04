using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.BaseResult.Abstracts;

namespace Vallet.Application.BaseResult.Concretes
{
    public class Result : IBaseResult
    {
        public Result()
        {
        }

        public Result(bool success)

        {
            Success = success;
        }

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
