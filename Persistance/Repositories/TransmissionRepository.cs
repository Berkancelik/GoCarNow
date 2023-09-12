using Application.Services.Repositories;
using CorePersistance.Repositories;
using Domain.Entities;
using Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class TransmissionRepository : EfRepositoryBase<Transmission, Guid, BaseDbContext>, ITransmissionRepository
    {
        public TransmissionRepository(BaseDbContext context) : base(context)
        {
        }
    }
}