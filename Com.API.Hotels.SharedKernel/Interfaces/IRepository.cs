using Ardalis.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.API.Hotels.SharedKernel.Interfaces
{
    public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}
