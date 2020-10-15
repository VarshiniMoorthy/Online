using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OnlineShoppingSystem.Models
{
    [Table("ProductTable")]
    public class ProductModel
    {
        
        [Required]
        
        public int ProductId { get; set; }
        [Required(ErrorMessage ="productName is requried")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="productPrice is requried") ]
        public double ProductPrice { get; set; }
        [Required(ErrorMessage ="ProductQuantity is required")]
        public int ProductQuantity { get; set; }
        [Required(ErrorMessage ="description is requried") ]
        public string Description { get; set; }
        //public string ProductQuality { get; set; }
        [Required(ErrorMessage ="productcolor is requried")]
        public string ProductColor { get; set; }
        [Required(ErrorMessage ="brand is requried")]
        public string Brand { get; set; }
        //public byte[] ProductImage { get; set; }

        public int CategoryId { get; set; }

        public  CategoryModel categoryModel { get;set; }
    }
}