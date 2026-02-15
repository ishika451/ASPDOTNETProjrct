using System.ComponentModel.DataAnnotations;

namespace ASPDOTNETProjrct.Models
{
    public class Category
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage = "The Category Name is required")]
        [MaxLength(100,ErrorMessage ="Category name cannot exceed 200 character ")]
        public string Name{ get; set; }
        public string? Description{ get; set; }

        public ICollection<Post> Posts { get; set; }




    }
}
