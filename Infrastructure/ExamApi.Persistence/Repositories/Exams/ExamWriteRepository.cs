using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using ExamApi.Persistence.Contexts;

namespace ExamApi.Persistence.Repositories
{
    public class ExamWriteRepository : WriteRepository<Exams>, IExamWriteRepository
    {
        public ExamWriteRepository(ExamAPIDbContext context) : base(context)
        {

        }
    }
}
