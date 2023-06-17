using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Options.DeleteOption
{
    public class DeleteSurveyHandler : IRequestHandler<DeleteOptionRequest>
    {
        private readonly IOptionRepository _optionRepository;

        public DeleteSurveyHandler(IOptionRepository optionRepository)
        {
            _optionRepository = optionRepository;
        }

        public async Task<Unit> Handle(DeleteOptionRequest request, CancellationToken cancellationToken)
        {
            Option option = await _optionRepository.GetByIdAysnc(request.Id.ToString());
            _optionRepository.Delete(option);
            await _optionRepository.SaveAysnc();

            return Unit.Value;
        }
    }
}
