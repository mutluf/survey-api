using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MaSurvey.Persistence.Context;

namespace MaSurvey.Persistence.Repositories
{
    public class SurveyRepository : GenericRepository<Survey>, ISurveyRepository
    {
        public SurveyRepository(MaSurveyDbContext context) : base(context)
        {
        }
    }
}
