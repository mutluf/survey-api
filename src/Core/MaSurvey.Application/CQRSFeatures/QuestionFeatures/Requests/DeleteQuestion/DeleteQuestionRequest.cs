using MediatR;

namespace MaSurvey.Application.CQRSFeatures.QuestionFeatures.Requests.DeleteQuestion
{
    public class DeleteQuestionRequest:IRequest
    {
        public int Id { get; set; }
    }
}
