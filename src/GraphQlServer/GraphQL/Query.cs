using GraphQlServer.Context;
using GraphQlServer.Model;

namespace GraphQlServer.GraphQL
{
    public class Query
    {
        [GraphQLDescription("Get all account info")]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Account> GetAcccount([Service(ServiceKind.Synchronized)] ApplicationContext context)
        {
            return context.Accounts.AsQueryable();
        }

        [GraphQLDescription("Get all subtask info")]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<SubTask> GetSubTask([Service(ServiceKind.Synchronized)] ApplicationContext context)
        {
            return context.SubTasks.AsQueryable();
        }

        [GraphQLDescription("Get all Task list info")]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<TaskList> GetTaskList([Service(ServiceKind.Synchronized)] ApplicationContext context)
        {
            return context.TaskLists.AsQueryable();
        }
    }
}
