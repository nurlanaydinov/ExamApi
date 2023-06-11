using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Commands.Student.RemoveStudent
{
    public class RemoveStudentCommandHandler : IRequestHandler<RemoveStudentCommandRequest, RemoveStudentCommandResponse>
    {
        private readonly IStudentWriteRepository _studentWriteRepository;

        public RemoveStudentCommandHandler(IStudentWriteRepository studentWriteRepository)
        {
            _studentWriteRepository = studentWriteRepository;
        }

        public async Task<RemoveStudentCommandResponse> Handle(RemoveStudentCommandRequest request, CancellationToken cancellationToken)
        {
            await _studentWriteRepository.RemoveAsync(request.Id);
            await _studentWriteRepository.SaveAsync();
            return new();
        }
    }
}
