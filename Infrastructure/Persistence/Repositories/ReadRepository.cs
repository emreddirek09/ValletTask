using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Base;
using Vallet.Persistence.Contexts;

namespace Vallet.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ValletDbContext _context;

        public ReadRepository(ValletDbContext context)
        {
            _context = context;
        }

        public DbSet<T> table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = table.AsQueryable();
            if(!tracking)
                query=query.AsNoTracking();
            return query;
        }

        //public async Task<T> GetByIdAsync(string id) =>await table.FirstOrDefaultAsync(d => d.Id == Guid.Parse(id));

        //public async Task<T> GetByIdAsync(string id) => await table.FindAsync(Guid.Parse(id.ToString()));
        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
           var query = table.AsQueryable();
            if(!tracking)
                query=query.AsNoTracking();
            return await query.FirstOrDefaultAsync(d => d.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression,bool tracking=true)
        {
            var query = table.AsQueryable();
            if(!tracking)
                query=query.AsNoTracking();
            return await query.FirstOrDefaultAsync(expression);

        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var query = table.AsQueryable();
            if(!tracking)
                query=query.AsNoTracking();
            return query;
        }
    }
}
