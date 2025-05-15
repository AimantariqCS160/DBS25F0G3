using System.ComponentModel.DataAnnotations;

namespace ams.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        [Required]
        [MaxLength(20)]  // Assuming VARCHAR(20)
        public string StudentId { get; set; }

        [Required]
        [MaxLength(20)]  // course_id is also VARCHAR(20)
        public string CourseId { get; set; }

        [Required]
        public int Semester { get; set; }
    }
}
