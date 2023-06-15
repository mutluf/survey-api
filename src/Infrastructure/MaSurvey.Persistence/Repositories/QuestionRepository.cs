using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MaSurvey.Persistence.Context;

namespace MaSurvey.Persistence.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(MaSurveyDbContext context) : base(context)
        {
        }
    }
}
