namespace ExamApi.Application.Features.Queries.Student.GetStudentById
{
    public class GetStudentByIdQueryResponse
    {
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Class { get; set; }
    }
}
