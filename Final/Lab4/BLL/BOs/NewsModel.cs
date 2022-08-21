using System.ComponentModel.DataAnnotations;

namespace BLL.BOs
{
    public class NewsModel
    {
        public int? Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Title must be grater than or equal to 3 character")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid Date format")]
        public System.DateTime? Date { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Category Id must be numeric")]
        public int? CategoryId { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "User Id must be numeric")]
        public int? UserId { get; set; }
    }
}
