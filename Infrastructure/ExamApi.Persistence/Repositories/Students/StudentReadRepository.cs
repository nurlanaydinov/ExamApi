using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using ExamApi.Persistence.Contexts;

namespace ExamApi.Persistence.Repositories
{
    public class StudentReadRepository : ReadRepository<Students>, IStudentReadRepository
    {
        public StudentReadRepository(ExamAPIDbContext context) : base(context)
        {
        }
    }
}
