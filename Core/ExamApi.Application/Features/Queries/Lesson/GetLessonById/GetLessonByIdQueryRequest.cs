using MediatR;

namespace ExamApi.Application.Features.Queries.Lesson.GetLessonById
{
    public class GetLessonByIdQueryRequest : IRequest<GetLessonByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}
