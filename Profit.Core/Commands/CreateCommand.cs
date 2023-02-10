using MediatR;
using Microsoft.Extensions.Logging;
using Profit.Domain.Models;

namespace Profit.Core.Commands
{
    public sealed class CreateCommand : IRequest<long>
    {
        public string Data { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
