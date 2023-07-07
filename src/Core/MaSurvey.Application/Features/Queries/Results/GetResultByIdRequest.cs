using MaSurvey.Application.DTOs;
using MediatR;

namespace MaSurvey.Application.Features.Queries.Results
{
    public class GetResultByIdRequest:IRequest<GetResultByIdResponse>
    {
        public int Id { get; set; }
    }
}
