using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vallet.Application.IOC.Commands.CreateUser;
using Vallet.Application.IOC.Queries.GetAllUser;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly private IUserWriteRepository _userWriteRepository;
        readonly private IUserReadRepository _userReadRepository;
        readonly private IMediator _mediator;

        public UsersController(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository, IMediator mediator)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GET([FromQuery] GetAllUserQueryRequest getAllUserQueryRequest)
        {
            GetAllUserQueryResponse response = await _mediator.Send(getAllUserQueryRequest);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GET(string id)
        {
            User user = await _userReadRepository.GetByIdAsync(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateUserCommandRequest createUser)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUser);
            return Ok(response);
        }
    }
}
