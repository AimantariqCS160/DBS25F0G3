using System;
using System.ComponentModel.DataAnnotations;

namespace ams.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Required]
        [MaxLength(20)]  // Assuming VARCHAR(20)
        public string StudentId { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime SubmittedAt { get; set; }
    }
}
