using MediatR;

namespace ExamApi.Application.Features.Queries.Student.GetStudentById
{
    public class GetStudentByIdQueryRequest : IRequest<GetStudentByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}
