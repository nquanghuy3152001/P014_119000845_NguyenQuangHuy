using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
         [Required]
        public string Content { get; set; }
        
        public string CreatedAt { get; set; }

        
    }
}