using GraphQlServer.Repository.Entities;
using GraphQlServer.Repository.Interfaces;

namespace GraphQlServer.GraphQL
{
    public class Query
    {
        [GraphQLDescription("Get all account")]
        public List<Account> GetAcccount([Service(ServiceKind.Synchronized)] IAccountRepository repository)
        {

            return repository.GetAllAccount();
        }

        [GraphQLDescription("Get account id")]
        public Account GetAcccountId([Service(ServiceKind.Synchronized)] IAccountRepository repository, int id)
        {
            return repository.GetAccountById(id);
        }
    }
}
