using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;
using Vallet.Persistence.Contexts;

namespace Vallet.Persistence.Repositories
{
    public class DaireBorcReadRepository : ReadRepository<DaireBorc>, IDaireBorcReadRepository
    {

        public DaireBorcReadRepository(ValletDbContext context) : base(context)
        {
        }
    }
}
