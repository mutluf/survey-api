using MediatR;

namespace MaSurvey.Application.Features.Queries.Surveys.GetSurveyById
{
    public class GetSurveyByIdRequest:IRequest<GetSurveyByIdResponse>
    {
        public int Id { get; set; }
    }
}
