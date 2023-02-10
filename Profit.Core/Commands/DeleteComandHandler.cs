using MediatR;
using Profit.Core;
using Profit.Domain.Models;

namespace Profit.Core.Commands
{
    public class DeleteComandHandler : IRequestHandler<DeleteCommand>
    {
        private readonly IRepository<Message> _repository;

        public DeleteComandHandler(IRepository<Message> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCommand request,
            CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
