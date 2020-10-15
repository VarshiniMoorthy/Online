using OnlineShoppingSystem.DAL;
using OnlineShoppingSystem.Entity;

namespace OnlineShoppingSystem.BL
{
    public interface IAccountBL
    {
        void SignUp(Account account);
        Account Login(Account account);
    }
    public class AccountBL : IAccountBL
    {
        IAccountRespository accountRespository;
        public AccountBL()
        {
            accountRespository = new AccountRespository();
        }
        public void SignUp(Account account)
        {
            accountRespository.AddUser(account);
        }

        public Account Login(Account account)
        {
            return accountRespository.Login(account);
        }

    }
}
