﻿using AutoMapper;
using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.CQRSFeatures.SurveyFeatures.Requests.CreateSurvey
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
            Survey survey = _mapper.Map<Survey>(request);
            await _surveyRepository.AddAysnc(survey);
            await _surveyRepository.SaveAysnc();

            return Unit.Value;
        }
    }
}