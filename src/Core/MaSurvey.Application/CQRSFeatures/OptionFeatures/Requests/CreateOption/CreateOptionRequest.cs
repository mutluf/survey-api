using MaSurvey.Application.DTOs;
using MediatR;

namespace MaSurvey.Application.CQRSFeatures.OptionFeatures.Requests.CreateOption
{
    public class CreateOptionRequest:IRequest
    {
        public OptionDTO OptionDTO { get; set; }
    }
}
