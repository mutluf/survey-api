using MaSurvey.Application.DTOs;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Surveys.CreateSurvey
{
    public class CreateSurveyRequest : IRequest<CreateSurveyResponse>
    {
        public SurveyDTO Survey { get; set; }
    }
}
