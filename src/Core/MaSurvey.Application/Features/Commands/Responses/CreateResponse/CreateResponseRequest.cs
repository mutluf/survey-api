using MaSurvey.Application.DTOs;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Responses.CreateResponse
{
    public class CreateResponseRequest:IRequest
    {
        public ResponseDTO Response { get; set; }
    }
}
