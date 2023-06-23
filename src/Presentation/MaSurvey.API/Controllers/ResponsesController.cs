using MaSurvey.Application.Features.Commands.Responses.CreateResponse;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaSurvey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ResponsesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateResponseRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
