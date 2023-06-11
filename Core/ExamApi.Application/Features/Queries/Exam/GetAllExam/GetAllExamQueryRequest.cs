using MediatR;

namespace ExamApi.Application.Features.Queries.Exam.GetAllExam
{
    public class GetAllExamQueryRequest : IRequest<GetAllExamQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
