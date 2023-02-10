using MediatR;
using Microsoft.EntityFrameworkCore;
using Profit.Core;
using Profit.Domain.Models;

namespace Profit.Infrastructure.Repositories
{
    public class MessageRepository : IRepository<Message>
    {
        private readonly IApplicationContext _context;

        public MessageRepository(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<long> CreateAsync(Message item, CancellationToken cancellationToken)
        {
            await _context.Messages.AddAsync(item);
            await _context.SaveChangesAsync(cancellationToken);

            return item.Id;
        }

        public async Task DeleteAsync(long id, CancellationToken cancellationToken)
        {
            var message = await _context.Messages.FindAsync(new object[] { id },
            cancellationToken);

            if (message == null)
                return;

            _context.Messages.Remove(message);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Message>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Messages.ToListAsync();
        }
    }
}
