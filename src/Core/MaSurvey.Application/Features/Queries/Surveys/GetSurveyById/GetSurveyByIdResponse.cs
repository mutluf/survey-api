using MaSurvey.Application.DTOs;
using MaSurvey.Domain.Entities;

namespace MaSurvey.Application.Features.Queries.Surveys.GetSurveyById
{
    public class GetSurveyByIdResponse
    {
        public SurveyResponse Survey { get; set; }
    }
}
