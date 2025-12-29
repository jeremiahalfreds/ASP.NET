using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        [Key] // annotation
        public int Id { get; set; } // get the Id
        
        [Required] // annotation
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 3 and 100 characters.")]
        public string Title { get; set; } = string.Empty; // get title
        
        [Required] // annotation
        public string Description { get; set; } = string.Empty; // get content/description
        
        [Required] // annotation
        public DateTime CreatedAt { get; set; } = DateTime.Now; // get datetime
    }
}
