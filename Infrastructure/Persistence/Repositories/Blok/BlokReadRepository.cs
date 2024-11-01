using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories; 
using Vallet.Persistence.Contexts;
using Vallet.Domain.Entities.Concretes;


namespace Vallet.Persistence.Repositories
{
    public class BlokReadRepository : ReadRepository<Blok>, IBlokReadRepository
    {
        public BlokReadRepository(ValletDbContext context) : base(context)
        {
        }
    }
}
