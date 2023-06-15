using AutoMapper;
using MaSurvey.Application.DTOs;
using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.CQRSFeatures.SurveyFeatures.Queries.GetAllSurvey
{
    public class GetAllSurveysHandler : IRequestHandler<GetAllSurveysRequest, GetAllSurveysResponse>
    {
        private readonly ISurveyRepository _surveyRepository;
        private readonly IMapper _mapper;
        public GetAllSurveysHandler(ISurveyRepository surveyRepository, IMapper mapper)
        {
            _surveyRepository = surveyRepository;
            _mapper = mapper;
        }

        public async Task<GetAllSurveysResponse> Handle(GetAllSurveysRequest request, CancellationToken cancellationToken)
        {
            List<Survey> surveys = _surveyRepository.GetAll();
            IList<SurveyDTO> surveyDTOs= _mapper.Map<IList<SurveyDTO>>(surveys);

            return new()
            {
                SurveyDTOs = surveyDTOs,
            };
        }
    }
}
