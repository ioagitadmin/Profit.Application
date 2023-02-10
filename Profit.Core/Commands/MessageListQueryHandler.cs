using MediatR;
using Profit.Domain.Models;

namespace Profit.Core.Commands
{
    public class MessageListQueryHandler : IRequestHandler<MessageListQuery, MessageList>
    {
        private readonly IRepository<Message> _repository;

        public MessageListQueryHandler(IRepository<Message> repository)
        {
            _repository = repository;
        }

        public async Task<MessageList> Handle(MessageListQuery request, CancellationToken cancellationToken)
        {
            var messages = await _repository.GetAllAsync(cancellationToken);

            return new MessageList { Messages = messages };
        }
    }
}
