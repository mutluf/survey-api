using AutoMapper;
using MaSurvey.Application.DTOs;
using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MaSurvey.Application.Features.Queries.Surveys.GetSurveyById
{
    public class GetSurveyByIdHandler : IRequestHandler<GetSurveyByIdRequest, GetSurveyByIdResponse>
    {
        private readonly ISurveyRepository _surveyRepository;
        private readonly IMapper _mapper;               
        public GetSurveyByIdHandler(ISurveyRepository surveyRepository, IMapper mapper)
        {
            _surveyRepository = surveyRepository;
            _mapper = mapper;
        }

        public async Task<GetSurveyByIdResponse> Handle(GetSurveyByIdRequest request, CancellationToken cancellationToken)
        {

            Survey survey = await _surveyRepository.Table.Include(q => q.Questions).ThenInclude(o => o.Options).FirstOrDefaultAsync(s=>s.Id==request.Id);


            SurveyDTO dto= _mapper.Map<SurveyDTO>(survey);

            return new()
            {
                Survey = dto
            };
        }
    }
}
