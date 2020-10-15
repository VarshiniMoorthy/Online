using System.Collections.Generic;
using System.Web.Mvc;
using OnlineShoppingSystem.Entity;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.BL;
using System.ComponentModel.DataAnnotations;
using System;

namespace OnlineShoppingSystem.Controllers
{
    [Authorize(Roles ="admin")]
    public class ProductController : Controller
    {
        IProductBL productBL;
        public ProductController()
        {
            productBL = new ProductBL();
        }
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult ProductDetails()
        {
            List<Product> products = productBL.ProductDetails();            
            return View(products);
            
        }
        [ValidateAntiForgeryToken]
        public ActionResult Details(int id)
        {
           
            Product product = productBL.Details(id);
            return View(product);
        }
        public ActionResult Delete(int id)
        {
            productBL.Delete(id);
            return RedirectToAction("ProductDetails");

        }
       
        [HttpGet]
        public ActionResult AddProduct()
        {
           
            List<Category> categories= productBL.DownDrop();
            ViewBag.categories = new SelectList(categories, "CategoryId", "CategoryName");
                return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(ProductModel productModel)
        {
            if (ModelState.IsValid)
                {

               
                Product product = AutoMapper.Mapper.Map<ProductModel, Product>(productModel);
                List<Category> categories = productBL.DownDrop();
                ViewBag.categories = new SelectList(categories, "CategoryId", "CategoryName");
                productBL.AddProduct(product);

                return RedirectToAction("ProductDetails");

                }
           
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            
            List<Category> categories = productBL.DownDrop();
            ViewBag.categories = new SelectList(categories, "CategoryId", "CategoryName");
            Product product = productBL.GetProductId(id);

            return View(product);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductModel productModel)
        {
            ////try
            ////{
                if (ModelState.IsValid)
                {
                    Product product = AutoMapper.Mapper.Map<ProductModel, Product>(productModel);

                    List<Category> categories = productBL.DownDrop();
                    ViewBag.categories = new SelectList(categories, "CategoryId", "CategoryName");
                    productBL.Update(product);
                    return RedirectToAction("ProductDetails");

                }

            //}
            //catch (Exception)
            //{

            //    View("Error");
            //}
            return View();
        }


    }
}

