using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required] 
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Users() { }
    }
}
