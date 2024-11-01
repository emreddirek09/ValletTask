using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Domain.Entities.Base;

namespace Vallet.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> table { get; }
    }
}
