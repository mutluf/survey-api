using MediatR;

namespace MaSurvey.Application.CQRSFeatures.QuestionFeatures.Queries.GetAllQuestions
{
    public class GetAllQuestionsRequest:IRequest<GetAllQuestionsResponse>
    {
    }
}
