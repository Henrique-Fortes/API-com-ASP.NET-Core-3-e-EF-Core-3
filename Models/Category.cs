using System.ComponentModel.DataAnnotations;

namespace revisaoef.Models
{
    public class Category
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must contain between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must contain between 3 and 60 characteres")]
        public string Title {get; set;}
    }
}