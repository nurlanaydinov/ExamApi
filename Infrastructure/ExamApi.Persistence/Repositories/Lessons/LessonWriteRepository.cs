using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using ExamApi.Persistence.Contexts;

namespace ExamApi.Persistence.Repositories
{
    public class LessonWriteRepository : WriteRepository<Lessons>, ILessonWriteRepository
    {
        public LessonWriteRepository(ExamAPIDbContext context) : base(context)
        {

        }
    }
}
