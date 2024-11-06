using MediatR; 
using Microsoft.AspNetCore.Mvc;
using Vallet.Application.Features.Commands.FUser.CreateUser;
using Vallet.Application.Features.Commands.FUser.RemoveUser;
using Vallet.Application.Features.Commands.FUser.UpdateUser;
using Vallet.Application.Features.Queries.FUser.GetAllUser;
using Vallet.Application.Features.Queries.FUser.GetByIdUser;

namespace VALLETAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly private IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllUserQueryRequest getAllUserQueryRequest)
        {
            GetAllUserQueryResponse response = await _mediator.Send(getAllUserQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdUserQueryRequest queryRequest)
        {
            GetByIdUserQueryResponse response = await _mediator.Send(queryRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateUserCommandRequest createUser)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUser);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> PuT(UpdateUserCommandRequest userCommandRequest)
        {
            UpdateUserCommandResponse response = await _mediator.Send(userCommandRequest);
            return Ok(response);
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
