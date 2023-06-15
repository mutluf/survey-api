using MaSurvey.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace MaSurvey.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
