using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(20,ErrorMessage ="Length shoud not exceed 20 characters.")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,int.MaxValue,ErrorMessage = "Display Order must be between 1-2147483647")]
        public int DisplayOrder { get; set; }
    }
}
