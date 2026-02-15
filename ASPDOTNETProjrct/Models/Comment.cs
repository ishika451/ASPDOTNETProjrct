using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPDOTNETProjrct.Models
{
    public class Comment
    {
        public int  Id { get; set; }

        [Required(ErrorMessage = "The UserName is required.")]

        [MaxLength(100, ErrorMessage = "The UserName Cannot exceed 100 character")]
        public string  UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        [Required]
        public String Content { get; set; }

        [ForeignKey("Post")]
            public int PostID { get; set; }
            public Post Post { get; set; }

    }
}
