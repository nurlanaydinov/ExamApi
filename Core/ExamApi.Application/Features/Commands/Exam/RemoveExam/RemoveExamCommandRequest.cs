using MediatR;

namespace ExamApi.Application.Features.Commands.Exam.RemoveExam
{
    public class RemoveExamCommandRequest : IRequest<RemoveExamCommandResponse>
    {
        public string Id { get; set; }
    }
}
