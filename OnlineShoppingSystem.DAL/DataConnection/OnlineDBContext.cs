using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingSystem.Entity;



namespace OnlineShoppingSystem.DAL
{
    public class OnlineDBContext :DbContext
    {
        public DbSet<Account> account { get; set; }
        public DbSet<OnlineShopping> onlineShopping { get; set; }

    }
}
