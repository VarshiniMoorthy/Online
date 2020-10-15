
using System.Data.Entity;
using OnlineShoppingSystem.Entity;
namespace OnlineShoppingSystem.DAL
{
    public class OnlineShoppingContext :DbContext
    {
        public OnlineShoppingContext() : base("name = OnlineConnect")
        {

        }
         public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
       // public DbSet<SignUpModel> signUpModel { get; set; }
        public DbSet<Account> Accounts { get; set; }
        //public DbSet<LoginView> loginViews { get; set; }
    }
}