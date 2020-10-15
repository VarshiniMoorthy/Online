using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingSystem.Models
{
    [Table("CategoryTable")]

    public class CategoryModel
    {
        [Required(ErrorMessage ="enter categoryName") ]
        public string CategoryName { get; set; }
        [Required(ErrorMessage ="Enter categoryId")]
        
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Enter categoryDescription")]
        public string CategoryDescription { get; set; }
       
    }
}