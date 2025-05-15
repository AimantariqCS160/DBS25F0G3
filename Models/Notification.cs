using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ams.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        public int UserId { get; set; }

        [MaxLength(100)]
        public string Title { get; set; } = null!;

        public string Message { get; set; } = null!;

        public DateTime SentAt { get; set; }

        // Navigation property (optional, if you have a User model)
        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
