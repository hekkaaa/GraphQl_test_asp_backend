using GraphQlServer.Context;
using GraphQlServer.Model;

namespace GraphQlServer.GraphQL
{
    public class Query
    {
        [GraphQLDescription("Get all account")]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Account> GetAcccount([Service(ServiceKind.Synchronized)] ApplicationContext context)
        {
            return context.Accounts.AsQueryable();
        }
    }
}
