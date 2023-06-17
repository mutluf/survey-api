using MaSurvey.Application.DTOs;

namespace MaSurvey.Application.Features.Queries.Surveys.GetAllSurvey
{
    public class GetAllSurveysResponse
    {
        public IList<SurveyDTO> SurveyDTOs { get; set; }
    }
}
