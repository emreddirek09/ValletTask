﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vallet.Application.Features.Commands.FApart.CreateApart;
using Vallet.Application.Features.Commands.FApart.RemoveApart;
using Vallet.Application.Features.Commands.FApart.UpdateApart;
using Vallet.Application.Features.Commands.FUser.RemoveUser;
using Vallet.Application.Features.Queries.FApart.GetAllApart;
using Vallet.Application.Features.Queries.FApart.GetByIdApart;

namespace Vallet.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApartController : ControllerBase
    {
      readonly private IMediator _mediator;

        public ApartController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllApartQueryRequest queryRequest)
        {
            GetAllApartQueryResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdApartQueryRequest queryRequest)
        {
            GetByIdApartQueryResponse response = await _mediator.Send(queryRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateApartCommandRequest queryRequest)
        {
            CreateApartCommandResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> PuT([FromBody] UpdateApartCommandRequest queryRequest)
        {
            UpdateApartCommandResponse response = await _mediator.Send(queryRequest);
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
