using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ams.Models
{
    public class AssigningProfessor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssignmentId { get; set; }

        [MaxLength(20)]
        public string? ProfessorId { get; set; }

        [MaxLength(20)]
        public string? CourseId { get; set; }

        [MaxLength(20)]
        public string? DepartmentId { get; set; }

        [MaxLength(20)]
        public string? SessionId { get; set; }

        // Navigation properties
        [ForeignKey("ProfessorId")]
        public Professor? Professor { get; set; }

        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

        [ForeignKey("SessionId")]
        public Session? Session { get; set; }
    }
}
