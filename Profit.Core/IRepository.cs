using Profit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit.Core
{
    public interface IRepository<T>
            where T : class
    {
        Task<long> CreateAsync(Message item, CancellationToken cancellationToken);
        Task DeleteAsync(long id, CancellationToken cancellationToken);
        Task<List<Message>> GetAllAsync(CancellationToken cancellationToken);
    }
}