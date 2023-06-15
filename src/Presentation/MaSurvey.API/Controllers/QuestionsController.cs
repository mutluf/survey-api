using MaSurvey.Application.CQRSFeatures.QuestionFeatures.Queries.GetAllQuestions;
using MaSurvey.Application.CQRSFeatures.QuestionFeatures.Requests.CreateQuestion;
using MaSurvey.Application.CQRSFeatures.QuestionFeatures.Requests.DeleteQuestion;
using MaSurvey.Application.CQRSFeatures.SurveyFeatures.Queries.GetAllSurvey;
using MaSurvey.Application.CQRSFeatures.SurveyFeatures.Requests.CreateSurvey;
using MaSurvey.Application.CQRSFeatures.SurveyFeatures.Requests.DeleteSurvey;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MaSurvey.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public QuestionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateQuestionRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            GetAllQuestionsRequest request = new();
            GetAllQuestionsResponse response = await _mediator.Send(request);
            return Ok(response.QuestionDTOs);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteQuestionRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
