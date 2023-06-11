using ExamApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ExamApi.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
