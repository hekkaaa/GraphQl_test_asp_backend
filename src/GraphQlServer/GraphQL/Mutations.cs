using GraphQlServer.Context;
using GraphQlServer.Repository.Entities;
using GraphQlServer.Repository.Interfaces;

namespace GraphQlServer.GraphQL
{
    public class Mutations
    {
        [GraphQLDescription("Add new Account")]
        public async Task<Account> CreateNewAccount([Service(ServiceKind.Synchronized)] IAccountRepository repository, Account newAccount)
        {
            int res = repository.AddNewAccount(newAccount);

            return new Account() { Id = res };
        }
    }
}
