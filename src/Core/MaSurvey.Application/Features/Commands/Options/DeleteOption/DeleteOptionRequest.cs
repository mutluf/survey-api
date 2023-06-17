using MediatR;

namespace MaSurvey.Application.Features.Commands.Options.DeleteOption
{
    public class DeleteOptionRequest : IRequest
    {
        public int Id { get; set; }
    }
}
