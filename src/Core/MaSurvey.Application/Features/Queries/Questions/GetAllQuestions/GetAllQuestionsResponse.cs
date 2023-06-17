using MaSurvey.Application.DTOs;

namespace MaSurvey.Application.Features.Queries.Questions.GetAllQuestions
{
    public class GetAllQuestionsResponse
    {
        public IList<QuestionDTO> QuestionDTOs { get; set; }
    }
}
