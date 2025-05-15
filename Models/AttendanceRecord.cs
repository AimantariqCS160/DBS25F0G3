using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ams.Models
{
    public enum AttendanceStatus
    {
        Present,
        Absent,
        Leave
    }

    public class AttendanceRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceId { get; set; }

        [MaxLength(20)]
        public string? CourseId { get; set; }

        [MaxLength(20)]
        public string? StudentId { get; set; }

        [MaxLength(20)]
        public string? ProfessorId { get; set; }

        public DateTime Date { get; set; }

        public AttendanceStatus Status { get; set; }

        // Navigation properties
        [ForeignKey("ProfessorId")]
        public Professor? Professor { get; set; }

        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }
    }
}

