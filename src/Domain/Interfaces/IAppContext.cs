using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Interfaces
{
    public interface IAppContext
    {

        DbSet<OrderAggregateRoot> OrdersAggregateRoots { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);


    }
}
