using AutoMapper;
using MaSurvey.Application.DTOs;
using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.Features.Queries.Options.GetAllOptions
{
    public class GetAllSurveysHandler : IRequestHandler<GetAllOptionsRequest, GetAllOptionsResponse>
    {
        private readonly IOptionRepository _optionRepository;
        private readonly IMapper _mapper;
        public GetAllSurveysHandler(IOptionRepository optionRepository, IMapper mapper)
        {
            _optionRepository = optionRepository;
            _mapper = mapper;
        }

        public async Task<GetAllOptionsResponse> Handle(GetAllOptionsRequest request, CancellationToken cancellationToken)
        {
            List<Option> options = _optionRepository.GetAll();
            IList<OptionDTO> optionDTOs = _mapper.Map<IList<OptionDTO>>(options);

            return new()
            {
                OptionDTOs = optionDTOs,
            };
        }
    }
}
