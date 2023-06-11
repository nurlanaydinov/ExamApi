namespace ExamApi.Application.Features.Queries.Exam.GetAllExam
{
    public class GetAllExamQueryResponse
    {
        public int TotalCount { get; set; }
        public object Exams { get; set; }
    }
}
