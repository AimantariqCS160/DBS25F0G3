using System.ComponentModel.DataAnnotations;

namespace ams.Models
{
    public class Professor
    {
        [Key]
        [MaxLength(20)]  // VARCHAR(20)
        public string ProfessorId { get; set; }

        [Required]
        [MaxLength(100)]  // VARCHAR(100)
        public string PName { get; set; }

        [Required]
        [MaxLength(100)]  // VARCHAR(100)
        public string Designation { get; set; }

        [Required]
        [MaxLength(20)]  // VARCHAR(20)
        public string DepartmentId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
