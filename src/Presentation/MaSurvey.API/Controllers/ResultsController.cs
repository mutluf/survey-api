using MaSurvey.Application.Features.Queries.Results;
using MaSurvey.Application.Features.Queries.Surveys.GetSurveyById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaSurvey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ResultsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{Id}/result")]
        public async Task<IActionResult> Get([FromRoute]GetResultByIdRequest request)
        {
            GetResultByIdResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
