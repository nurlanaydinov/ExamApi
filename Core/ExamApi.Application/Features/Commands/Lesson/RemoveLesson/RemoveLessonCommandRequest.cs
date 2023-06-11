using MediatR;

namespace ExamApi.Application.Features.Commands.Lesson.RemoveLesson
{
    public class RemoveLessonCommandRequest : IRequest<RemoveLessonCommandResponse>
    {
        public string Id { get; set; }
    }
}
