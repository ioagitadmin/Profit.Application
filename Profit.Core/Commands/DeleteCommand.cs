using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit.Core.Commands
{
    public class DeleteCommand : IRequest
    {
        public long Id { get; set; }
    }
}
