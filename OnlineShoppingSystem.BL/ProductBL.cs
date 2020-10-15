using System.Linq;
using OnlineShoppingSystem.Entity;
using OnlineShoppingSystem.DAL;
using System.Collections.Generic;

namespace OnlineShoppingSystem.BL
{

    public interface IProductBL
    {
        void AddProduct(Product product);
        List<Product> ProductDetails();
        Product Details(int id);
        void Delete(int id);
        Product GetProductId(int id);
        void Update(Product product);
        List<Category> DownDrop();
    }
    public class ProductBL : IProductBL
    {
        IProductRepository productRepository;
        public ProductBL()
        {
            productRepository = new ProductRepository();  

        }
        public List<Product> ProductDetails()
        {
            return productRepository.ProductDetails();

        }

        public void AddProduct(Product product)
        {
            productRepository.AddProduct(product);

        }
        public Product Details(int id)
        {
            return productRepository.Details(id);
        }
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }
        public Product GetProductId(int id)
        {

            return productRepository.GetProduct(id);
        }
        public void Update(Product product)
        {
            productRepository.Update(product);
        }
        public List<Category> DownDrop()
        {
            return productRepository.DropDownList();
        }
    }
}
