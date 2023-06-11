using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using ExamApi.Persistence.Contexts;

namespace ExamApi.Persistence.Repositories
{
    public class StudentWriteRepository : WriteRepository<Students>, IStudentWriteRepository
    {
        public StudentWriteRepository(ExamAPIDbContext context) : base(context)
        {

        }
    }
}
