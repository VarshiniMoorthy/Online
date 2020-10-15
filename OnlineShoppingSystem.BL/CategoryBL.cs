
using OnlineShoppingSystem.Entity;
using OnlineShoppingSystem.DAL;
using System.Linq;
using System.Collections.Generic;

namespace OnlineShoppingSystem.BL
{
    public interface ICategoryBL
    {
        List<Category> CategoryDetails();
        Category Details(int id);
        void Delete(int id);
        void Update(Category category);
        void AddCategory(Category category);
        Category GetCategoryId(int id);
    }
    public class CategoryBL : ICategoryBL
    {
        ICategoryRespository categoryRespository;
        public CategoryBL()
        {
            categoryRespository = new CategoryRespository();
        }

        public List<Category> CategoryDetails()
        {

            return categoryRespository.CategoryDetails();


        }
        public Category Details(int id)
        {

            return categoryRespository.Details(id);
        }
        public void Delete(int id)
        {

            categoryRespository.Delete(id);
        }
        public void Update(Category category)
        {

            categoryRespository.Update(category);
        }
        public void AddCategory(Category category)
        {

            categoryRespository.AddCategory(category);
        }
        public Category GetCategoryId(int id)
        {


            return categoryRespository.GetCategory(id);
        }


    }
}


