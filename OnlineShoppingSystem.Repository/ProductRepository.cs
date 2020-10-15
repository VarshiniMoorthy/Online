using System.Collections.Generic;
using System.Linq;
using OnlineShoppingSystem.Entity;

namespace OnlineShoppingSystem.DAL
{
    public interface IProductRepository
    {
        List<Product> ProductDetails();
        Product Details(int id);
        void Delete(int id);
        Product GetProduct(int id);
        void AddProduct(Product product);
        void Update(Product product);
        List<Category> DropDownList();
    }
    public class ProductRepository:IProductRepository
    {
        

        public List<Product> ProductDetails()
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {

                List<Product> data = onlineShoppingContext.products.ToList();
                return data;
            }
        }
        public Product Details(int id)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                Product product = onlineShoppingContext.products.Find(id);
                return product;
            }
        }
        public void Delete(int id)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                Product product = onlineShoppingContext.products.Find(id);
                onlineShoppingContext.products.Remove(product);
                onlineShoppingContext.SaveChanges();


            }
        }
        public Product GetProduct(int id)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                return onlineShoppingContext.products.Where(product => product.ProductId == id).FirstOrDefault();
            }
        }

        public void  AddProduct(Product product)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                onlineShoppingContext.products.Add(product);
                onlineShoppingContext.SaveChanges();
                
            }

        } 
        public void Update(Product product)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            { 
                onlineShoppingContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
                onlineShoppingContext.SaveChanges();
            }
        }
        public List<Category> DropDownList()
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                List<Category> categories = onlineShoppingContext.Categories.ToList();
                return categories;
            }

        }
    }
}