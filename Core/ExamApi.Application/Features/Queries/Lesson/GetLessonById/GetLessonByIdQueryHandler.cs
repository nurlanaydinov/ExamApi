using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using MediatR;

namespace ExamApi.Application.Features.Queries.Lesson.GetLessonById
{
    public class GetLessonByIdQueryHandler : IRequestHandler<GetLessonByIdQueryRequest, GetLessonByIdQueryResponse>
    {
        private readonly ILessonReadRepository _lessonReadRepository;

        public GetLessonByIdQueryHandler(ILessonReadRepository lessonReadRepository)
        {
            _lessonReadRepository = lessonReadRepository;
        }

        public async Task<GetLessonByIdQueryResponse> Handle(GetLessonByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Lessons lesson = await _lessonReadRepository.GetByIdasync(request.Id, false);
            return new()
            {
                LessonCode = lesson.LessonCode,
                LessonName = lesson.LessonName,
                Class = lesson.Class,
                TeacherName = lesson.TeacherName,
                TeacherSurname = lesson.TeacherSurname
            };
        }
    }
}
