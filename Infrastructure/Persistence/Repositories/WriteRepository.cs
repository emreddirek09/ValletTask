using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Base;
using Vallet.Persistence.Contexts;

namespace Vallet.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ValletDbContext _context;

        public WriteRepository(ValletDbContext context)
        {
            _context = context;
        }

        public DbSet<T> table => _context.Set<T>();

        public Task<bool> AddAsync(T values)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRangeAsync(List<T> values)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T values)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T values)
        {
            throw new NotImplementedException();
        }
    }
}
