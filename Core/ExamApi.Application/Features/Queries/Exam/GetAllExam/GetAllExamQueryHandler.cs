using ExamApi.Application.Repositories;
using MediatR;

namespace ExamApi.Application.Features.Queries.Exam.GetAllExam
{
    public class GetAllExamQueryHandler : IRequestHandler<GetAllExamQueryRequest, GetAllExamQueryResponse>
    {
        private readonly IExamReadRepository _examReadRepository;

        public GetAllExamQueryHandler(IExamReadRepository examReadRepository)
        {
            _examReadRepository = examReadRepository;
        }

        public async Task<GetAllExamQueryResponse> Handle(GetAllExamQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _examReadRepository.GetAll(false).Count();
            var exams = _examReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.LessonCode,
                p.StudentNumber,
                p.ExamDate,
                p.Rating             
            }).ToList();

            return new()
            {
                TotalCount = totalCount,
                Exams = exams
            };
        }
    }
}
