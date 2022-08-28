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

        public List<Account> GetAccount()
        {
            return _context.Accounts.ToList();
        }

        public bool AddNewAccount(Account newAccount)
        {
            var res = _context.Accounts.Add(newAccount);
            _context.SaveChanges();
            var q = newAccount.Id;
            return true;
        }
    }
}
