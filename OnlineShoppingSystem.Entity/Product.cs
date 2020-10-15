using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingSystem.Entity
{
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(20)]
        [Index(IsUnique =true)]
        public string ProductName { get; set; }

        [Required]
        public double ProductPrice { get; set; }

        [Required]
        public int ProductQuantity { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [MaxLength(20)]
        public string ProductColor { get; set; }

        [Required]
        [MaxLength(20)]
        public string Brand { get; set; }
      
        public int CategoryId { get; set; }


        public Category Category { get; set; }
        
        public Product()
        {

        }

    }
}

