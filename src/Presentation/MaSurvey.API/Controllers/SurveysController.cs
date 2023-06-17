using MaSurvey.Application.Features.Commands.Surveys.CreateSurvey;
using MaSurvey.Application.Features.Commands.Surveys.DeleteSurvey;
using MaSurvey.Application.Features.Queries.Surveys.GetAllSurvey;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MaSurvey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveysController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SurveysController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateSurveyRequest request2)
        {
            await _mediator.Send(request2);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            GetAllSurveysRequest request = new();
            GetAllSurveysResponse response = await _mediator.Send(request);
            return Ok(response.SurveyDTOs);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteSurveyRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
