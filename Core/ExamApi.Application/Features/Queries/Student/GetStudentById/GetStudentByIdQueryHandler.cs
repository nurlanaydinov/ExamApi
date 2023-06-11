using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using MediatR;

namespace ExamApi.Application.Features.Queries.Student.GetStudentById
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQueryRequest, GetStudentByIdQueryResponse>
    {
        private readonly IStudentReadRepository _studentReadRepository;

        public GetStudentByIdQueryHandler(IStudentReadRepository studentReadRepository)
        {
            _studentReadRepository = studentReadRepository;
        }

        public async Task<GetStudentByIdQueryResponse> Handle(GetStudentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Students students = await _studentReadRepository.GetByIdasync(request.Id);
            return new()
            {
                StudentNumber = students.StudentNumber,
                StudentName = students.StudentName,
                StudentSurname = students.StudentSurname,
                Class = students.Class
            };
        }
    }
}
