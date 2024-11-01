using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Persistence.Contexts;
using Microsoft.Extensions.Configuration;

namespace Vallet.Persistence.Configurations
{
    public class ValletDbContextFactory : IDesignTimeDbContextFactory<ValletDbContext>
    {
        public ValletDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ValletDbContext>();
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);


            return new ValletDbContext(optionsBuilder.Options);
        }
    }
}
