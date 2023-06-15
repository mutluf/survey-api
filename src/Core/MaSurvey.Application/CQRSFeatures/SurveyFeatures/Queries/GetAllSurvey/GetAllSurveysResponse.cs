using MaSurvey.Application.DTOs;

namespace MaSurvey.Application.CQRSFeatures.SurveyFeatures.Queries.GetAllSurvey
{
    public class GetAllSurveysResponse
    {
        public IList<SurveyDTO> SurveyDTOs { get; set; }
    }
}
