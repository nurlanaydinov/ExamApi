using ExamApi.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace ExamApi.Domain.Entities
{
    public class Exams : BaseEntity
    {
        [MaxLength(3)]
        public string LessonCode { get; set; }
        public int StudentNumber { get; set; }
        public DateTime ExamDate { get; set; }
        public int Rating { get; set; }
    }
}
