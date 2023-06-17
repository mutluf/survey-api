using MaSurvey.Application.DTOs;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Questions.CreateQuestion
{
    public class CreateQuestionRequest : IRequest
    {
        public QuestionDTO QuestionDTO { get; set; }
    }
}
