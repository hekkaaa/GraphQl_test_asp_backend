using GraphQlServer.Repository.Entities;

namespace GraphQlServer.Repository.Interfaces
{
    public interface IAccountRepository
    {
        int AddNewAccount(Account newAccount);
        List<Account> GetAllAccount();
        Account GetAccountById(int id);
    }
}