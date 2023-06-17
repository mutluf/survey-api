using MaSurvey.Application.DTOs;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Surveys.CreateSurvey
{
    public class CreateSurveyRequest : IRequest
    {
        public List<QuestionDTO> Questions { get; set; }
    }
}
