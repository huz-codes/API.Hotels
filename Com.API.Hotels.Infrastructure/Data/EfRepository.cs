using Ardalis.Specification.EntityFrameworkCore;
using Com.API.Hotels.SharedKernel.Interfaces;

namespace Com.API.Hotels.Infrastructure.Data
{
    public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
    {
        public EfRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
