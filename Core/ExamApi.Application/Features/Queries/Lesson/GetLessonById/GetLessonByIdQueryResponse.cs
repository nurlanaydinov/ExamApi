namespace ExamApi.Application.Features.Queries.Lesson.GetLessonById
{
    public class GetLessonByIdQueryResponse
    {
        public string LessonCode { get; set; }
        public string LessonName { get; set; }
        public int Class { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
    }
}
