using GraphQlServer.Repository.Entities;

namespace GraphQlServer.Repository.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAccount();
        bool AddNewAccount(Account newAccount);
    }
}