namespace ExamApi.Application.Features.Queries.Exam.GetExamById
{
    public class GetExamByIdQueryResponse
    {
        public string LessonCode { get; set; }
        public int StudentNumber { get; set; }
        public DateTime ExamDate { get; set; }
        public int Rating { get; set; }
    }
}
