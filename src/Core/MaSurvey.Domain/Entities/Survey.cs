using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class Survey:BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int SolvedCount { get; set; }
        public User? User { get; set; }
        public int UserId { get; set; }
        public string Link { get; set; } = "/api/Surveys/";
        public ICollection<Question>? Questions { get; set; }
        
    }
}
