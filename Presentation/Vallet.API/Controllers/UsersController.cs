using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vallet.Application.Features.Commands.FUser.CreateUser;
using Vallet.Application.Features.Commands.FUser.RemoveUser;
using Vallet.Application.Features.Commands.FUser.UpdateUser;
using Vallet.Application.Features.Queries.FUser.GetAllUser;
using Vallet.Application.Features.Queries.FUser.GetByIdUser;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.API.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPut]
        public async Task<IActionResult> PuT([FromBody] UpdateUserCommandRequest userCommandRequest)
        {
            UpdateUserCommandResponse response = await _mediator.Send(userCommandRequest);
            return Ok();
        }
        
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveUserCommandRequest removeUserCommand)
        {
            RemoveUserCommandResponse response = await _mediator.Send(removeUserCommand);
            return Ok();
        }
    }
}
