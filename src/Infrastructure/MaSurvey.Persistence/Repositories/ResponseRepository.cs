using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MaSurvey.Persistence.Context;

namespace MaSurvey.Persistence.Repositories
{
    public class ResponseRepository : GenericRepository<Response>, IResponseRepository
    {
        public ResponseRepository(MaSurveyDbContext context) : base(context)
        {
        }
    }
}
