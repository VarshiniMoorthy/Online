using OnlineShoppingSystem.Entity;
using System.Linq;

namespace OnlineShoppingSystem.DAL
{
    public interface IAccountRespository
    {
        void AddUser(Account account);
        Account Login(Account account);
    }
    public  class AccountRespository:IAccountRespository
    {
        
        public void AddUser(Account account)
        {
            using (OnlineShoppingContext context = new OnlineShoppingContext())
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }
        }

        public Account Login(Account account)
        {
            using (OnlineShoppingContext context = new OnlineShoppingContext())
            {
                var result = context.Accounts.Where(value => value.EmailId == account.EmailId && value.Password == account.Password).FirstOrDefault();
                return result;
            }
        }

    }
}
