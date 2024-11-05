using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vallet.Application.Features.Commands.FApartDebt.CreateApartDebt;
using Vallet.Application.Features.Commands.FApartDebt.RemoveApartDebt;
using Vallet.Application.Features.Commands.FApartDebt.UpdateApartDebt;
using Vallet.Application.Features.Queries.FApartDebt.GetAllApartDebt;
using Vallet.Application.Features.Queries.FApartDebt.GetByIdApartDebt;

namespace Vallet.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApartDebtController : ControllerBase
    {

        readonly private IMediator _mediator;

        public ApartDebtController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllApartDebtQueryRequest queryRequest)
        {
            GetAllApartDebtQueryResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdApartDebtQueryRequest queryRequest)
        {
            GetByIdApartDebtQueryResponse response = await _mediator.Send(queryRequest);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateApartDebtCommandRequest queryRequest)
        {
            CreateApartDebtCommandResponse response = await _mediator.Send(queryRequest);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> PuT([FromBody] UpdateApartDebtCommandRequest queryRequest)
        {
            UpdateApartDebtCommandResponse response = await _mediator.Send(queryRequest);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveApartDebtCommandRequest queryRequest)
        {
            RemoveApartDebtCommandResponse response = await _mediator.Send(queryRequest);
            return Ok();
        }
    }
}
