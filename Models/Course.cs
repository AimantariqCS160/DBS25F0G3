using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ams.Models
{
    public class Course
    {
        [Key]
        [MaxLength(20)]
        public string CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; }

        public int? CreditHours { get; set; }

        [MaxLength(20)]
        public string? DepartmentId { get; set; }

        // Navigation property
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
    }
}
