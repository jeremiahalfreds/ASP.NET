using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        //[Key] // annotation
        public int Id { get; set; } // get the Id
        
        [Required] // annotation
        public string Title { get; set; } = string.Empty; // get title
        
        [Required] // annotation
        [StringLength(500)]
        public string Description { get; set; } = string.Empty; // get content/description
        
        [Required] // annotation
        public DateTime CreatedAt { get; set; } = DateTime.Now; // get datetime

        [Required]
        public DateTime UpdatedAt {  get; set; } = DateTime.Now;
        
        public DiaryEntry() { }
    }
}
