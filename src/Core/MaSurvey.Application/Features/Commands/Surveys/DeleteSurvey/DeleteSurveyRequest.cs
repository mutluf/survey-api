using MediatR;

namespace MaSurvey.Application.Features.Commands.Surveys.DeleteSurvey
{
    public class DeleteSurveyRequest : IRequest
    {
        public int Id { get; set; }
    }
}
