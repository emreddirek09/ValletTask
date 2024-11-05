﻿ 
using Vallet.Application.BaseResult.Abstracts;

namespace Vallet.Application.BaseResult.Concretes
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T? Data { get; set; }

        public DataResult()
        {

        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public DataResult(T? data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
    }
}
