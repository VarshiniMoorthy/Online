using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingSystem.Entity
{
   public class Category   {
        [MaxLength(20)]
        [Required]
        [Index(IsUnique = true)]
        public string CategoryName { get; set; }

        [Key]       
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryDescription { get; set; }       

        public ICollection<Product> Products { get; set; }
      
        public Category()
        {

        }
    }
    
}

