using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [ MaxLength(200)]
        [MinLength(20)]
        [Required]
        [System.ComponentModel.Bindable(true)]
public virtual string ImageUrl { get; set; } = string.Empty;
        public string Content { get; set; }
        [ MaxLength(500)]
        [MinLength(100)]
        [Required]
        public string Author { get; set; }
        [Required]
        public string CreatedAt { get; set; }

      
    }
}