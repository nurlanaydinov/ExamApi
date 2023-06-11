using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Queries.Student.GetAllStudent
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQueryRequest, GetAllStudentQueryResponse>
    {
        private readonly IStudentReadRepository _studentReadRepository;

        public GetAllStudentQueryHandler(IStudentReadRepository studentReadRepository)
        {
            _studentReadRepository = studentReadRepository;
        }

        public async Task<GetAllStudentQueryResponse> Handle(GetAllStudentQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _studentReadRepository.GetAll(false).Count();
            var students = _studentReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.StudentNumber,
                p.StudentName,
                p.StudentSurname,
                p.Class
            }).ToList();

            return new()
            {
                TotalCount = totalCount,
                Students = students
            };
        }
    }
}
