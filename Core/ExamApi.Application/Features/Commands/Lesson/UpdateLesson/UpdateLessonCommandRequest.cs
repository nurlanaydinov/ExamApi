using MediatR;

namespace ExamApi.Application.Features.Commands.Lesson.UpdateLesson
{
    public class UpdateLessonCommandRequest : IRequest<UpdateLessonCommandResponse>
    {
        public string Id { get; set; }
        public string LessonCode { get; set; }
        public string LessonName { get; set; }
        public int Class { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
    }
}
