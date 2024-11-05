using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public async Task<bool> AddAsync(T values)
        {
            EntityEntry<T> entityEntry = await table.AddAsync(values);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> values)
        {
            await table.AddRangeAsync(values);
            return true;
        }

        public bool Delete(T values)
        {
            EntityEntry entityEntry = table.Remove(values);
            return entityEntry.State == EntityState.Deleted;
        }
 
        public async Task<bool> DeleteAsync(string id)
        {
            if (Guid.TryParse(id, out Guid guidId))
            {
                T model = await table.FirstOrDefaultAsync(data => data.Id == guidId);
                return Delete(model);
            }
            else
            { 
                return false;
            }
        }

        public bool DeleteRange(List<T> values)
        {
            table.RemoveRange(values);
            return true;
        }

        public bool Update(T values)
        {
            EntityEntry entry = table.Update(values);
            return entry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync() =>await _context.SaveChangesAsync();
    }
}
