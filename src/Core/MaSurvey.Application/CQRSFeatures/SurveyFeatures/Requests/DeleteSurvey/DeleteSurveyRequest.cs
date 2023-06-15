using MediatR;

namespace MaSurvey.Application.CQRSFeatures.SurveyFeatures.Requests.DeleteSurvey
{
    public class DeleteSurveyRequest:IRequest
    {
        public int Id { get; set; }
    }
}
