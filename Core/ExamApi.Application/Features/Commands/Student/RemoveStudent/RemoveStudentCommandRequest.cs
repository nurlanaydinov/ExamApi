using MediatR;

namespace ExamApi.Application.Features.Commands.Student.RemoveStudent
{
    public class RemoveStudentCommandRequest : IRequest<RemoveStudentCommandResponse>
    {
        public string Id { get; set; }
    }
}
