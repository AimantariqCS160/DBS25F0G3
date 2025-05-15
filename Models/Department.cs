using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ams.Models
{
    public class Department
    {
        [Key]
        [MaxLength(20)]  // department_id VARCHAR(20)
        public string DepartmentId { get; set; }

        [Required]
        [MaxLength(100)]  // department_name VARCHAR(100)
        public string DepartmentName { get; set; }

        [MaxLength(50)]  // session_id VARCHAR(50)
        public string? SessionId { get; set; }

        // Navigation property (optional)
        [ForeignKey("SessionId")]
        public Session? Session { get; set; }
    }
}
