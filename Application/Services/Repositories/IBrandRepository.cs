using CorePersistance.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public interface IBrandRepository : IAsyncRepository<Brand, Guid>, IRepository<Brand, Guid>
    {
    }

    public interface ICarRepository : IAsyncRepository<Car, Guid>, IRepository<Car, Guid>
    {
    }

    public interface IModelRepository : IAsyncRepository<Model, Guid>, IRepository<Model, Guid>
    {
    }
    public interface IFuelRepository : IAsyncRepository<Fuel, Guid>, IRepository<Fuel, Guid>
    {
    }
    public interface ITransmissionRepository : IAsyncRepository<Transmission, Guid>, IRepository<Transmission, Guid>
    {
    }
  



}
