using MediatR;
using Microsoft.AspNetCore.Mvc;
using Vallet.Application.Features.Commands.FBlock.CreateBlock;
using Vallet.Application.Features.Commands.FBlock.UpdateBlock;
using Vallet.Application.Features.Commands.FUser.RemoveUser;
using Vallet.Application.Features.Queries.FBlock.GetAllBlock;
using Vallet.Application.Features.Queries.FBlock.GetByIdBlock;

namespace VALLETAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlockController : ControllerBase
    {
        readonly private IMediator _mediator;

        public BlockController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllBlockQueryRequest queryRequest)
        {
            GetAllBlockQueryResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBlockQueryRequest queryRequest)
        {
            GetByIdBlockQueryResponse response = await _mediator.Send(queryRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateBlockCommandRequest queryRequest)
        {
            CreateBlockCommandResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> PuT([FromBody] UpdateBlockCommandRequest queryRequest)
        {
            UpdateBlockCommandResponse response = await _mediator.Send(queryRequest);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            var command = new RemoveUserCommandRequest { Id = id };
            RemoveUserCommandResponse response = await _mediator.Send(command);
            return Ok(response);

        }
    }
}
