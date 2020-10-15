using System.Web.Mvc;
using OnlineShoppingSystem.Entity;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem.BL;
using AutoMapper;
using System.Web.Security;
using System;
using System.Web;

namespace OnlineShoppingSystem.Controllers
{
    public class AccountController : Controller
    {
        IAccountBL accountBL;
      public AccountController()
        {
            accountBL = new AccountBL();
        }
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginView loginView)
        {
          
            Account account = Mapper.Map<LoginView, Account>(loginView);

            Account accountDetails = accountBL.Login(account);
            if (accountDetails != null)
            {
               // accountDetails.Role = "admin";
                FormsAuthentication.SetAuthCookie(account.EmailId, false);

                var authTicket = new FormsAuthenticationTicket(1, account.EmailId, DateTime.Now, DateTime.Now.AddMinutes(20), false, accountDetails.Role);
                string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                HttpContext.Response.Cookies.Add(authCookie);
                return RedirectToAction("ProductDetails", "Product");
            }
            else
            {
            
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(account);

                }
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        [HttpGet]
        [AllowAnonymous]
        public ActionResult SignUp()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult SignUp(SignUpModel signUpView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Account account = Mapper.Map<SignUpModel, Account>(signUpView);
                    account.Role = "user";
                    accountBL.SignUp(account);
                    return RedirectToAction("Login");

                }
            }
            catch
            {
                View("Error");
            }
            return View();

        }
        [AllowAnonymous]
        public ActionResult Home()
        {
            return View();
        }

       
    }
}


