using MaSurvey.Application.CQRSFeatures.SurveyFeatures.Requests.CreateSurvey;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> Post(CreateSurveyRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
