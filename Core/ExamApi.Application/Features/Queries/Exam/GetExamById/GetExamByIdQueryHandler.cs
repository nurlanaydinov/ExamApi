using ExamApi.Application.Repositories;
using ExamApi.Domain.Entities;
using MediatR;

namespace ExamApi.Application.Features.Queries.Exam.GetExamById
{
    public class GetExamByIdQueryHandler : IRequestHandler<GetExamByIdQueryRequest, GetExamByIdQueryResponse>
    {
        private readonly IExamReadRepository _examReadRepository;

        public GetExamByIdQueryHandler(IExamReadRepository examReadRepository)
        {
            _examReadRepository = examReadRepository;
        }

        public async Task<GetExamByIdQueryResponse> Handle(GetExamByIdQueryRequest request, CancellationToken cancellationToken)
        {
            Exams exam =  await _examReadRepository.GetByIdasync(request.Id);
            return new()
            {
               StudentNumber = exam.StudentNumber,
               LessonCode = exam.LessonCode,
               ExamDate = exam.ExamDate,
               Rating = exam.Rating
            };
        }
    }
}
