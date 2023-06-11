using MediatR;

namespace ExamApi.Application.Features.Queries.Exam.GetExamById
{
    public class GetExamByIdQueryRequest : IRequest<GetExamByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}
