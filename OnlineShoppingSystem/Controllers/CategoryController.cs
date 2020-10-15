using System.Collections.Generic;
using System.Web.Mvc;
using OnlineShoppingSystem.Entity;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.BL;
namespace OnlineShoppingSystem.Controllers
{
    [Authorize(Roles = "admin")]

    public class CategoryController : Controller
    {
        ICategoryBL categoryBL;
        public CategoryController()
        {
            categoryBL = new CategoryBL();
        }
        
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult CategoryDetails()
        {
            List<Category> categories = categoryBL.CategoryDetails();
            return View(categories);
        }
        [ValidateAntiForgeryToken]
        public ActionResult Details(int id)
        {
            Category category = categoryBL.Details(id);
            return View(category);
        } 
        public ActionResult Delete(int id)
        {
            categoryBL.Delete(id);

            return RedirectToAction("CategoryDetails");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category category = categoryBL.GetCategoryId(id);
            return View(category);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryModel categoryModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Category category = AutoMapper.Mapper.Map<CategoryModel, Category>(categoryModel);
                    categoryBL.Update(category);
                    return RedirectToAction("CategoryDetails");

                }
            }
            catch
            {
                View("Error");
            }
            return View();
        }

        public ActionResult AddCategories()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCategories(CategoryModel categoryModel)
        {
            //try
            //{
                if (ModelState.IsValid)
                {

                    Category category = AutoMapper.Mapper.Map<CategoryModel, Category>(categoryModel);

                    categoryBL.AddCategory(category);
                    return RedirectToAction("CategoryDetails");
                }
            //}
            //catch
            //{
            //    View("Error");
            //}
            return View();
        }
    }


}