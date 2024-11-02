﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;
using Vallet.Persistence.Contexts;

namespace Vallet.Persistence.Repositories
{
    public class DaireBorcWriteRepository : WriteRepository<DaireBorc>, IDaireBorcWriteRepository
    {
        public DaireBorcWriteRepository(ValletDbContext context) : base(context)
        {
        }
    }
}