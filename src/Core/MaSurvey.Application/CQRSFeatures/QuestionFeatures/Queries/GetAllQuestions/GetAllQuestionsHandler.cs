using AutoMapper;
using MaSurvey.Application.DTOs;
using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.CQRSFeatures.QuestionFeatures.Queries.GetAllQuestions
{
    public class GetAllQuestionsHandler : IRequestHandler<GetAllQuestionsRequest, GetAllQuestionsResponse>
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;
        public GetAllQuestionsHandler(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<GetAllQuestionsResponse> Handle(GetAllQuestionsRequest request, CancellationToken cancellationToken)
        {
            List<Question> questions = _questionRepository.GetAll();
            IList<QuestionDTO> questionDTOs= _mapper.Map<IList<QuestionDTO>>(questions);

            return new()
            {
                QuestionDTOs = questionDTOs,
            };
        }
    }
}
