using MaSurvey.Application.Features.Commands.Options.CreateOption;
using MaSurvey.Application.Features.Commands.Options.DeleteOption;
using MaSurvey.Application.Features.Queries.Options.GetAllOptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MaSurvey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OptionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateOptionRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            GetAllOptionsRequest request = new();
            GetAllOptionsResponse response = await _mediator.Send(request);
            return Ok(response.OptionDTOs);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOptionRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
