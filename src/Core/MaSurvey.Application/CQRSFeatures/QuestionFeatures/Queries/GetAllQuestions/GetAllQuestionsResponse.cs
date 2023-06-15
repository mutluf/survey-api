using MaSurvey.Application.DTOs;

namespace MaSurvey.Application.CQRSFeatures.QuestionFeatures.Queries.GetAllQuestions
{
    public class GetAllQuestionsResponse
    {
        public IList<QuestionDTO> QuestionDTOs { get; set; }
    }
}
