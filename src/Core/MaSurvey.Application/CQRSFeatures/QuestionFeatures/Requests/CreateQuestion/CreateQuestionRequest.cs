using MaSurvey.Application.DTOs;
using MediatR;

namespace MaSurvey.Application.CQRSFeatures.QuestionFeatures.Requests.CreateQuestion
{
    public class CreateQuestionRequest:IRequest
    {
        public QuestionDTO QuestionDTO { get; set; }
    }
}
