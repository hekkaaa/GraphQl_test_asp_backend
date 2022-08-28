using GraphQlServer.Repository.Entities;

namespace GraphQlServer.Service
{
    public interface ITestService
    {
        bool AddAccount(Account model);
        List<Account> GetAllAccount();
    }
}