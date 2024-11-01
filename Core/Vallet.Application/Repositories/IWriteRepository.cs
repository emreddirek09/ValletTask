﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Base;

namespace Vallet.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T values);
        Task<bool> AddRangeAsync(List<T> values);
        Task<bool> UpdateAsync(T values);
        Task<bool> DeleteAsync(T values);
        Task<bool> DeleteAsync(string id);
        Task<int> SaveAsync();
    }
}
