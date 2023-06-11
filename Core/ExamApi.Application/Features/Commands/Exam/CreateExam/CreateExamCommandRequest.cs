using MediatR;

namespace ExamApi.Application.Features.Commands.Exam.CreateExam
{
    public class CreateExamCommandRequest : IRequest<CreateExamCommandResponse>
    {
        public string LessonCode { get; set; }
        public int StudentNumber { get; set; }
        public DateTime ExamDate { get; set; }
        public int Rating { get; set; }
    }
}
