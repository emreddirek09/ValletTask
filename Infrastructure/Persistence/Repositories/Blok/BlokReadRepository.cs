 
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;
using Vallet.Persistence.Contexts;  


namespace Vallet.Persistence.Repositories
{
    public class BlokReadRepository : ReadRepository<Blok>, IBlokReadRepository
    {
        public BlokReadRepository(ValletDbContext context) : base(context)
        {
        }
    }
}
