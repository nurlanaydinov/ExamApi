using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using ExamApi.Persistence.Contexts;

namespace ExamApi.Persistence.Repositories
{
    public class ExamReadRepository : ReadRepository<Exams>, IExamReadRepository
    {
        public ExamReadRepository(ExamAPIDbContext context) : base(context)
        {
        }
    }
}
