using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class Question:BaseEntity
    {
        public Survey? Survey { get; set; }
        public int SurveyId { get; set; }
        public ICollection<Option>? Options { get; set; }
    }
}
