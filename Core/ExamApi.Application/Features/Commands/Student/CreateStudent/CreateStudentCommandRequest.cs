using MediatR;

namespace ExamApi.Application.Features.Commands.Student.CreateStudent
{
    public class CreateStudentCommandRequest : IRequest<CreateStudentCommandResponse>
    {
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Class { get; set; }
    }
}
