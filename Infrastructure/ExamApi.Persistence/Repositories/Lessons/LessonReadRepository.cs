using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using ExamApi.Persistence.Contexts;

namespace ExamApi.Persistence.Repositories
{
    public class LessonReadRepository : ReadRepository<Lessons>, ILessonReadRepository
    {
        public LessonReadRepository(ExamAPIDbContext context) : base(context)
        {
        }
    }
}
