using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class AnsweredOption:BaseEntity
    {
        public string? OptionContent { get; set; }
        public Option? Option { get; set; }
        public int OptionId { get; set; }
        public AnsweredQuestion? Question { get; set; }
        public int? QuestionId { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}
