using System.ComponentModel.DataAnnotations;

namespace ams.Models
{
    public class Session
    {
        [Key]
        [MaxLength(20)]  // VARCHAR(20)
        public string SessionId { get; set; }

        [Required]
        [MaxLength(1)]   // VARCHAR(1)
        public string Section { get; set; }
    }
}
