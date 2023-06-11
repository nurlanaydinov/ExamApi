using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Queries.Lesson.GetAllLesson
{
    public class GetAllLessonQueryHandler : IRequestHandler<GetAllLessonQueryRequest, GetAllLessonQueryResponse>
    {
        private readonly ILessonReadRepository _lessonReadRepository;

        public GetAllLessonQueryHandler(ILessonReadRepository lessonReadRepository)
        {
            _lessonReadRepository = lessonReadRepository;
        }

        public async Task<GetAllLessonQueryResponse> Handle(GetAllLessonQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _lessonReadRepository.GetAll(false).Count();
            var lessons = _lessonReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(l => new
            {
                l.Id,
                l.LessonCode,
                l.LessonName,
                l.Class,
                l.TeacherName,
                l.TeacherSurname
            }).ToList();

            return new()
            {
                TotalCount = totalCount,
                Lessons = lessons
            };
        }
    }
}
