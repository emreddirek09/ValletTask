using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vallet.Domain.Entities.Base;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.Persistence.Contexts
{
    public class ValletDbContext : DbContext
    {
        public ValletDbContext(DbContextOptions<ValletDbContext> options) : base(options) { }
        public DbSet<Blok> Bloks { get; set; }
        public DbSet<Daire> Daires { get; set; }
        public DbSet<DaireBorc> DaireBorcs { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<User> Users { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var entity in datas)
            {
                _ = entity.State switch
                {
                    EntityState.Added => entity.Entity.CreatedTime = DateTime.UtcNow,
                    EntityState.Modified => entity.Entity.UpdateTime = DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
