using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Surveys.DeleteSurvey
{
    public class DeleteSurveyHandler : IRequestHandler<DeleteSurveyRequest>
    {
        private readonly ISurveyRepository _surveyRepository;

        public DeleteSurveyHandler(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }

        public async Task<Unit> Handle(DeleteSurveyRequest request, CancellationToken cancellationToken)
        {
            Survey survey = await _surveyRepository.GetByIdAysnc(request.Id.ToString());
            _surveyRepository.Delete(survey);
            await _surveyRepository.SaveAysnc();

            return Unit.Value;
        }
    }
}
