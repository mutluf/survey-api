using MaSurvey.Application.Features.Commands.Surveys.CreateSurvey;
using MaSurvey.Application.Features.Commands.Surveys.DeleteSurvey;
using MaSurvey.Application.Features.Queries.Results;
using MaSurvey.Application.Features.Queries.Surveys.GetAllSurvey;
using MaSurvey.Application.Features.Queries.Surveys.GetSurveyById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaSurvey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes ="User")]
    public class SurveysController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SurveysController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [Authorize(AuthenticationSchemes = "User")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateSurveyRequest request)
        {
            CreateSurveyResponse response =  await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            GetAllSurveysRequest request = new();
            GetAllSurveysResponse response = await _mediator.Send(request);
            return Ok(response.SurveyDTOs);
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]GetSurveyByIdRequest request)
        {
            GetSurveyByIdResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteSurveyRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }


        [HttpGet("{Id}/result")]
        public async Task<IActionResult> Get([FromRoute] GetResultByIdRequest request)
        {
            GetResultByIdResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
