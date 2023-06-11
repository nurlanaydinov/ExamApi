using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using MediatR;

namespace ExamApi.Application.Features.Commands.Student.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommandRequest, UpdateStudentCommandResponse>
    {
        private readonly IStudentWriteRepository _studentWriteRepository;
        private readonly IStudentReadRepository _studentReadRepository;

        public UpdateStudentCommandHandler(IStudentWriteRepository studentWriteRepository, IStudentReadRepository studentReadRepository)
        {
            _studentWriteRepository = studentWriteRepository;
            _studentReadRepository = studentReadRepository;
        }

        public async Task<UpdateStudentCommandResponse> Handle(UpdateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            Students students = await _studentReadRepository.GetByIdasync(request.Id);
            students.StudentNumber = request.StudentNumber;
            students.StudentName = request.StudentName;
            students.StudentSurname = request.StudentSurname;
            students.Class = request.Class;
            await _studentWriteRepository.SaveAsync();
            return new();
        }
    }
}
