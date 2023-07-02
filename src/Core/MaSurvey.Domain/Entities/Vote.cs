using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class Vote : BaseEntity
    {
        public Option? Option { get; set; }
        public int? OptionId { get; set; }
        public AnsweredOption? AnsweredOption { get; set; }
        public int? AnsweredOptionId { get; set; }
    }
}
