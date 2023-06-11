using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using MediatR;

namespace ExamApi.Application.Features.Commands.Lesson.UpdateLesson
{
    public class UpdateLessonCommandHandler : IRequestHandler<UpdateLessonCommandRequest, UpdateLessonCommandResponse>
    {
        private readonly ILessonWriteRepository _lessonWriteRepository;
        private readonly ILessonReadRepository _lessonReadRepository;

        public UpdateLessonCommandHandler(ILessonWriteRepository lessonWriteRepository, ILessonReadRepository lessonReadRepository)
        {
            _lessonWriteRepository = lessonWriteRepository;
            _lessonReadRepository = lessonReadRepository;
        }

        public async Task<UpdateLessonCommandResponse> Handle(UpdateLessonCommandRequest request, CancellationToken cancellationToken)
        {
            Lessons lessons = await _lessonReadRepository.GetByIdasync(request.Id);
            lessons.LessonCode = request.LessonCode;
            lessons.LessonName = request.LessonName;
            lessons.Class = request.Class;
            lessons.TeacherName = request.TeacherName;
            lessons.TeacherSurname = request.TeacherSurname;
            await _lessonWriteRepository.SaveAsync();
            return new();
        }
    }
}
