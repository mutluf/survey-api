using AutoMapper;
using MaSurvey.Application.DTOs;
using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Surveys.CreateSurvey
{
    public class CreateSurveyHandler : IRequestHandler<CreateSurveyRequest>
    {
        private readonly IMapper _mapper;
        private readonly ISurveyRepository _surveyRepository;
        public CreateSurveyHandler(IMapper mapper, ISurveyRepository surveyRepository)
        {
            _mapper = mapper;
            _surveyRepository = surveyRepository;
        }

        public async Task<Unit> Handle(CreateSurveyRequest request, CancellationToken cancellationToken)
        {
            Survey survey = _mapper.Map<Survey>(request.Survey);
            IList<Question> question = _mapper.Map<IList<Question>>(request.Survey.Questions);

            survey.Questions = question;          

            await _surveyRepository.AddAysnc(survey);           
            await _surveyRepository.SaveAysnc();         

            return Unit.Value;
        }
    }
}
