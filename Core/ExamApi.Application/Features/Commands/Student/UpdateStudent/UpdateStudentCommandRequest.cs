using MediatR;

namespace ExamApi.Application.Features.Commands.Student.UpdateStudent
{
    public class UpdateStudentCommandRequest : IRequest<UpdateStudentCommandResponse>
    {
        public string Id { get; set; }
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Class { get; set; }
    }
}
