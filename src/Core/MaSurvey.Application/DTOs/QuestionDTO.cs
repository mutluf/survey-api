namespace MaSurvey.Application.DTOs
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string QuestionContent { get; set; }
        public int QuestionRate { get; set; }
        public List<OptionDTO> Options { get; set; }
        
    }
}
