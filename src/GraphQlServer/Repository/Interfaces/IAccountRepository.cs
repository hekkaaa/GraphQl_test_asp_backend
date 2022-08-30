using GraphQlServer.Repository.Entities;

namespace GraphQlServer.Repository.Interfaces
{
    public interface IAccountRepository
    {
        bool AddNewAccount(Account newAccount);
        List<Account> GetAllAccount();
        Account GetAccountById(int id);
    }
}