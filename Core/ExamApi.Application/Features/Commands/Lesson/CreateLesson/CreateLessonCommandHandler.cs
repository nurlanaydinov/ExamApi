using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Commands.Lesson.CreateLesson
{
    public class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommandRequest, CreateLessonCommandResponse>
    {
        private readonly ILessonWriteRepository _lessonWriteRepository;

        public CreateLessonCommandHandler(ILessonWriteRepository lessonWriteRepository)
        {
            _lessonWriteRepository = lessonWriteRepository;
        }

        public async Task<CreateLessonCommandResponse> Handle(CreateLessonCommandRequest request, CancellationToken cancellationToken)
        {
            await _lessonWriteRepository.AddAsync(new()
            {
                LessonCode = request.LessonCode,
                LessonName = request.LessonName,
                Class = request.Class,
                TeacherName = request.TeacherName,
                TeacherSurname = request.TeacherSurname
            });
            await _lessonWriteRepository.SaveAsync();
            return new();
        }
    }
}
