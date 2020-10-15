
using System.Data.Entity;
using OnlineShoppingSystem.Entity;
namespace OnlineShoppingSystem.Models
{
    public class OnlineShoppingContext :DbContext
    {
        public OnlineShoppingContext() : base("name = OnlineConnect")
        {

        }
         public DbSet<CategoryModel> category { get; set; }
        public DbSet<ProductModel> products { get; set; }
        public DbSet<SignUpModel> signUpModel { get; set; }
        public DbSet<Account> accounts { get; set; }
        //public DbSet<LoginView> loginViews { get; set; }
    }
}