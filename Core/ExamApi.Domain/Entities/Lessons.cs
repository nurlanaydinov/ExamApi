using ExamApi.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace ExamApi.Domain.Entities
{
    public class Lessons : BaseEntity
    {
        [MaxLength(3)]
        public string LessonCode { get; set; }
        [MaxLength(30)]
        public string LessonName { get; set; }
        public int Class { get; set; }
        [MaxLength(20)]
        public string TeacherName { get; set; }
        [MaxLength(20)]
        public string TeacherSurname { get; set; }
    }
}
