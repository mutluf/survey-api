using MediatR;

namespace MaSurvey.Application.Features.Commands.Questions.DeleteQuestion
{
    public class DeleteQuestionRequest : IRequest
    {
        public int Id { get; set; }
    }
}
