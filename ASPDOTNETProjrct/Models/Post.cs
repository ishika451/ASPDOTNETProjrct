using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit.Sdk;

namespace ASPDOTNETProjrct.Models
{
    public class Post
    {
        [Key ]
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required.")]

         [MaxLength (400,ErrorMessage ="the tittle Cannot exceed 400 character")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]

        public string Content { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        [MaxLength(100, ErrorMessage = "the Author Cannot exceed 100 character")]
        public string Author { get; set; }
        public string Description { get; set; }
        public string FeatureImagePath { get; set; }

        public DateTime PublishedDate { get; set; }=DateTime.Now;


        [ForeignKey("Category")] 
        public int CategoryID { get; set; } 
        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
