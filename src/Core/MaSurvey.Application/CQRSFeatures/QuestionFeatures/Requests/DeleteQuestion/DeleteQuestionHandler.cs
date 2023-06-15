using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.CQRSFeatures.QuestionFeatures.Requests.DeleteQuestion
{
    public class DeleteSurveyHandler : IRequestHandler<DeleteQuestionRequest>
    {
        private readonly IQuestionRepository _questionRepository;

        public DeleteSurveyHandler(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<Unit> Handle(DeleteQuestionRequest request, CancellationToken cancellationToken)
        {
            Question question = await _questionRepository.GetByIdAysnc(request.Id.ToString());
            _questionRepository.Delete(question);
            await _questionRepository.SaveAysnc();

            return Unit.Value;
        }
    }
}
