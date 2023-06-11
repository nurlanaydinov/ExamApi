using MediatR;

namespace ExamApi.Application.Features.Commands.Exam.UpdateExam
{
    public class UpdateExamCommandRequest : IRequest<UpdateExamCommandResponse>
    {
        public string Id { get; set; }
        public string LessonCode { get; set; }
        public int StudentNumber { get; set; }
        public DateTime ExamDate { get; set; }
        public int Rating { get; set; }
    }
}
