using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Commands.Student.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommandRequest, CreateStudentCommandResponse>
    {
        private readonly IStudentWriteRepository _studentWriteRepository;

        public CreateStudentCommandHandler(IStudentWriteRepository studentWriteRepository)
        {
            _studentWriteRepository = studentWriteRepository;
        }

        public async Task<CreateStudentCommandResponse> Handle(CreateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            await _studentWriteRepository.AddAsync(new()
            {
                StudentNumber = request.StudentNumber,
                StudentName = request.StudentName,
                StudentSurname = request.StudentSurname,
                Class = request.Class
            });
            await _studentWriteRepository.SaveAsync();
            return new();
        }
    }
}
