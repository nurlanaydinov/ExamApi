using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Commands.Exam.RemoveExam
{
    public class RemoveExamCommandHandler : IRequestHandler<RemoveExamCommandRequest, RemoveExamCommandResponse>
    {
        private readonly IExamWriteRepository _examWriteRepository;
        public RemoveExamCommandHandler(IExamWriteRepository examWriteRepository)
        {
            _examWriteRepository = examWriteRepository;
        }
        public async Task<RemoveExamCommandResponse> Handle(RemoveExamCommandRequest request, CancellationToken cancellationToken)
        {
            await _examWriteRepository.RemoveAsync(request.Id);
            await _examWriteRepository.SaveAsync();
            return new();
        }
    }
}
