using GraphQlServer.Context;
using GraphQlServer.Repository.Entities;
using GraphQlServer.Repository.Interfaces;

namespace GraphQlServer.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationContext _context;
        public AccountRepository(ApplicationContext context)
        {
            _context = context;
        }


        public bool AddNewAccount(Account newAccount)
        {
            _context.SaveChanges();

            return true;
        }

        public List<Account> GetAllAccount()
        {
            return _context.Accounts.ToList();
        }

        public Account GetAccountById(int id)
        {
            return _context.Accounts.FirstOrDefault(a => a.Id == id);
        }
    }
}
