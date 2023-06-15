using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class Option:BaseEntity
    {
        public Question? Question { get; set; }
        public int QuestionId { get; set; }
    }
}
