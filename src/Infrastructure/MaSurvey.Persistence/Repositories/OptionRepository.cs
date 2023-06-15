using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MaSurvey.Persistence.Context;

namespace MaSurvey.Persistence.Repositories
{
    public class OptionRepository : GenericRepository<Option>, IOptionRepository
    {
        public OptionRepository(MaSurveyDbContext context) : base(context)
        {
        }
    }
}
