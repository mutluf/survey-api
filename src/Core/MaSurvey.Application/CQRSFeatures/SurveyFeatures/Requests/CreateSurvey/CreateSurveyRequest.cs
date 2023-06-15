using MaSurvey.Application.DTOs;
using MediatR;

namespace MaSurvey.Application.CQRSFeatures.SurveyFeatures.Requests.CreateSurvey
{
    public class CreateSurveyRequest:IRequest
    {
        public SurveyDTO SurveyDTO { get; set; }
    }
}
