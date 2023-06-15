using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class Survey:BaseEntity
    {
        public ICollection<Question>? Questions { get; set; }
    }
}
