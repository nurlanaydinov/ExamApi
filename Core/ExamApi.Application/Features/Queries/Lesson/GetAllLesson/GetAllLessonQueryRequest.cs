using MediatR;

namespace ExamApi.Application.Features.Queries.Lesson.GetAllLesson
{
    public class GetAllLessonQueryRequest : IRequest<GetAllLessonQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
