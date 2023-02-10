using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Profit.Core.Commands;
using Profit.Domain.Models;

namespace Profit.WebApi.Controllers
{
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class MessageController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public MessageController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<Message>> GetAll()
        {
            var result = await _mediator.Send(new MessageListQuery());

            return Ok(result.Messages);
        }

        [HttpPost]
        public async Task<ActionResult<long>> Create([FromBody] CreateMessageDto createMessageDto)
        {
            var command = _mapper.Map<CreateCommand>(createMessageDto);
            var messageId = await _mediator.Send(command);

            return Ok(messageId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteCommand
            {
                Id = id
            };

            await _mediator.Send(command);
            return NoContent();
        }
    }
}
