using GraphQlServer.Context;
using GraphQlServer.Model;

namespace GraphQlServer.GraphQL
{
    public class Mutations
    {
        [GraphQLDescription("Add new Account")]
        public async Task<bool> AddAccount([Service(ServiceKind.Synchronized)] ApplicationContext context, Account account)
        {   
            context.Accounts.Add(account);
            context.SaveChanges();
            return true;
        }
    }
}
