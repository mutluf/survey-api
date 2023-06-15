using MediatR;

namespace MaSurvey.Application.CQRSFeatures.OptionFeatures.Requests.DeleteOption
{
    public class DeleteOptionRequest:IRequest
    {
        public int Id { get; set; }
    }
}
