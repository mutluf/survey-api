using MaSurvey.Domain.Entities;

namespace MaSurvey.Application.DTOs
{
    public class ResponseDTO
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int? UserId { get; set; }
        public ICollection<AnsweredQuestionDTO>? Questions { get; set; }
    }
}
