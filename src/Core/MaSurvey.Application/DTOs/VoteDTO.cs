using MaSurvey.Domain.Entities;

namespace MaSurvey.Application.DTOs
{
    public class VoteDTO
    {
        public int Id { get; set; }
        public int? OptionId { get; set; }
        public int? AnsweredOptionId { get; set; }

    }
}
