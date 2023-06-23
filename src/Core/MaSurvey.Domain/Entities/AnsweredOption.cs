using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class AnsweredOption:BaseEntity
    {

        public AnsweredQuestion? Question { get; set; }
        public int AnsweredQuestionId { get; set; }


        public Option? Option { get; set; }
        public int OptionId { get; set; }
    }
}
