using MaSurvey.Application.DTOs;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Options.CreateOption
{
    public class CreateOptionRequest : IRequest
    {
        public OptionDTO OptionDTO { get; set; }
    }
}
