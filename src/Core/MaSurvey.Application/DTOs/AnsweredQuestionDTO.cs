namespace MaSurvey.Application.DTOs
{
    public class AnsweredQuestionDTO
    {
        public int QuestionId { get; set; }
        public int ResponseId { get; set; }
        public List<AnsweredOptionDTO> Options { get; set; }
    }
}
