using Microsoft.EntityFrameworkCore;
using Profit.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Profit.Core
{
    public interface IApplicationContext
    {
        DbSet<Message> Messages { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}