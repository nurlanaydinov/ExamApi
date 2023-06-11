using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Commands.Exam.CreateExam
{
    public class CreateExamCommandHandler : IRequestHandler<CreateExamCommandRequest, CreateExamCommandResponse>
    {
        private readonly IExamWriteRepository _examWriteRepository;
        public CreateExamCommandHandler(IExamWriteRepository examWriteRepository)
        {
            _examWriteRepository = examWriteRepository;
        }
        public async Task<CreateExamCommandResponse> Handle(CreateExamCommandRequest request, CancellationToken cancellationToken)
        {
            await _examWriteRepository.AddAsync(new()
            {
                LessonCode = request.LessonCode,
                StudentNumber = request.StudentNumber,
                ExamDate = request.ExamDate,
                Rating = request.Rating
            });
            await _examWriteRepository.SaveAsync();
            return new();
        }
    }
}
