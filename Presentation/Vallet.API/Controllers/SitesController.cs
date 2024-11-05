using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vallet.Application.Features.Commands.FSite.CreateSite;
using Vallet.Application.Features.Commands.FSite.RemoveSite;
using Vallet.Application.Features.Commands.FSite.UpdateSite;
using Vallet.Application.Features.Commands.FUser.RemoveUser;
using Vallet.Application.Features.Queries.FSite.GetAllSite;
using Vallet.Application.Features.Queries.FSite.GetByIdSite;
using Vallet.Application.Repositories;

namespace Vallet.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        readonly private IMediator _mediator;

        public SitesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllSiteQueryRequest queryRequest)
        {
            GetAllSiteQueryResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdSiteQueryRequest queryRequest)
        {
            GetByIdSiteQueryResponse response = await _mediator.Send(queryRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateSiteCommandRequest queryRequest)
        {
            CreateSiteCommandResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> PuT([FromBody] UpdateSiteCommandRequest queryRequest)
        {
            UpdateSiteCommandResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            var command = new RemoveSiteCommandRequest { Id = id };
            RemoveSiteCommandResponse response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
