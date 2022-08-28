using GraphQlServer.Repository.Entities;
using GraphQlServer.Repository.Interfaces;

namespace GraphQlServer.Service
{
    public class TestService : ITestService
    {
        private IAccountRepository _repository;

        public TestService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public bool AddAccount(Account model)
        {
            bool res = _repository.AddNewAccount(model);
            return res;
        }

        public List<Account> GetAllAccount()
        {
            return _repository.GetAccount();
        }
    }
}
