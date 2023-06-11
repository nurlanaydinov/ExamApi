using MediatR;

namespace ExamApi.Application.Features.Queries.Student.GetAllStudent
{
    public class GetAllStudentQueryRequest : IRequest<GetAllStudentQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
