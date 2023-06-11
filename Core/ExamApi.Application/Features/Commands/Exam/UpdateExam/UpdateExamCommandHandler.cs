using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using MediatR;

namespace ExamApi.Application.Features.Commands.Exam.UpdateExam
{
    public class UpdateExamCommandHandler : IRequestHandler<UpdateExamCommandRequest, UpdateExamCommandResponse>
    {
        private readonly IExamWriteRepository _examWriteRepository;
        private readonly IExamReadRepository _examReadRepository;
        public UpdateExamCommandHandler(IExamWriteRepository examWriteRepository, IExamReadRepository examReadRepository)
        {
            _examWriteRepository = examWriteRepository;
            _examReadRepository = examReadRepository;
        }

        public async Task<UpdateExamCommandResponse> Handle(UpdateExamCommandRequest request, CancellationToken cancellationToken)
        {
            Exams exams = await _examReadRepository.GetByIdasync(request.Id);
            exams.LessonCode = request.LessonCode;
            exams.StudentNumber = request.StudentNumber;
            exams.ExamDate = request.ExamDate;
            exams.Rating = request.Rating;
            await _examWriteRepository.SaveAsync();
            return new();
        }
    }
}
