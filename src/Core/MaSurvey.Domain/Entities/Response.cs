using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class Response:BaseEntity
    {
        public ICollection<AnsweredQuestion>? Questions { get; set; }
        public Survey? Survey { get; set; }
        public int SurveyId { get; set; }

        public User? User { get; set; }
        public int? UserId { get; set; }
    }
}
