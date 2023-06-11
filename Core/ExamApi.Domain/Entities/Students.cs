using ExamApi.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace ExamApi.Domain.Entities
{
    public class Students : BaseEntity
    {
        public int StudentNumber { get; set; }
        [MaxLength(30)]
        public string StudentName { get; set; }
        [MaxLength(30)]
        public string StudentSurname { get; set; }
        public int Class { get; set; }
    }
}
