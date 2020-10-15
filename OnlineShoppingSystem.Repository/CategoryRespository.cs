using System.Collections.Generic;
using System.Linq;
using OnlineShoppingSystem.Entity;

namespace OnlineShoppingSystem.DAL
{
    public interface ICategoryRespository
    {
        void AddCategory(Category category);
        List<Category> CategoryDetails();
        Category Details(int id);
         void Delete(int id);
        void Update(Category category);
        Category GetCategory(int id);
    }
    public class CategoryRespository:ICategoryRespository
    {

       
        public void AddCategory(Category category)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                onlineShoppingContext.Categories.Add(category);
                onlineShoppingContext.SaveChanges();
            }

        }
        public List<Category> CategoryDetails()
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {

                List<Category> data = onlineShoppingContext.Categories.ToList();
                return data;
            }
        }
        public Category Details(int id)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                Category category = onlineShoppingContext.Categories.Find(id);
                return category;
            }
        }
        public void Delete(int id)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                Category category = onlineShoppingContext.Categories.Find(id);
                onlineShoppingContext.Categories.Remove(category);
                onlineShoppingContext.SaveChanges();
                

            }
        }
     
        public void Update(Category category)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
             
                onlineShoppingContext.Entry(category).State = System.Data.Entity.EntityState.Modified;
                onlineShoppingContext.SaveChanges();
            }
        }
       
        public Category GetCategory(int id)
        {
            using (OnlineShoppingContext onlineShoppingContext = new OnlineShoppingContext())
            {
                return onlineShoppingContext.Categories.Where(category => category.CategoryId == id).FirstOrDefault();
            }
        }
       
    }

}
