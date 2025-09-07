using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class Users
    {
        //[Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter your name")]
        [StringLength(100, MinimumLength =3, ErrorMessage ="Name must be between 3 and 100 characters.")]
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
