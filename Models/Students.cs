using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ams.Models
{
    public class Student
    {
        [Key]
        [MaxLength(20)]  
        public string StudentId { get; set; }

        [Required]
        [MaxLength(100)]  
        public string SName { get; set; }

        public int? Semester { get; set; }  

        public DateTime? BirthDate { get; set; }  

        [MaxLength(20)]
        public string? DepartmentId { get; set; }

        public int? UserId { get; set; }

        // Navigation properties
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
