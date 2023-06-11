using MediatR;

namespace ExamApi.Application.Features.Commands.Lesson.CreateLesson
{
    public class CreateLessonCommandRequest : IRequest<CreateLessonCommandResponse>
    {
        public string LessonCode { get; set; }
        public string LessonName { get; set; }
        public int Class { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
    }
}
