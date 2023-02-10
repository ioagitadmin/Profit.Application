using MediatR;
using Profit.Core;
using Profit.Domain.Models;

namespace Profit.Core.Commands
{
    public class CreateComandHandler : IRequestHandler<CreateCommand, long>
    {
        private readonly IRepository<Message> _repository;

        public CreateComandHandler(IRepository<Message> repository)
        {
            _repository = repository;
        }

        public async Task<long> Handle(CreateCommand request,
            CancellationToken cancellationToken)
        {
            var item = new Message()
            {
                Data = request.Data,
                CreationTime = request.CreationTime
            };

            return await _repository.CreateAsync(item, cancellationToken);
        }
    }
}
