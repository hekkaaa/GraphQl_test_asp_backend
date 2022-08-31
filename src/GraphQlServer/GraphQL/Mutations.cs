using GraphQlServer.Context;
using GraphQlServer.Model;

namespace GraphQlServer.GraphQL
{
    public class Mutations
    {
        [GraphQLDescription("Add new Account")]
        public async Task<Account> AddNewAccount([Service(ServiceKind.Synchronized)] ApplicationContext context, 
            string name, string password)
        {
            Account tmpNewObj = new Account()
            {
                IsBlock = false,
                IsDelete = false,
                Name = name,
                Password = password
            }; 

            context.Accounts.Add(tmpNewObj);
            context.SaveChanges();
            return context.Accounts.FirstOrDefault(x=>x.Id == tmpNewObj.Id);
        }

        public async Task<TaskList> AddNewTaskList([Service(ServiceKind.Synchronized)] ApplicationContext context,
            int accountId,string title)
        {
            TaskList tmpNewtaskList = new TaskList()
            {
                Title = title,
                IsDelete = false
            };

            Account updateAccountInfo = context.Accounts.FirstOrDefault(y => y.Id == accountId);

            updateAccountInfo.TaskList.Add(tmpNewtaskList);
            context.Update(updateAccountInfo);
            context.SaveChanges();

            return context.TaskLists.FirstOrDefault(x => x.Id == tmpNewtaskList.Id);
        }

        public async Task<SubTask> AddNewSubTask([Service(ServiceKind.Synchronized)] ApplicationContext context,
            int taskListId, string name)
        {
            SubTask tmpNewtaskList = new SubTask()
            {
                Name = name,
                IsCompleted = false,
                IsDelete = false
            };

            TaskList updateTaskListInfo = context.TaskLists.FirstOrDefault(y => y.Id == taskListId);

            updateTaskListInfo.Tasks.Add(tmpNewtaskList);
            context.Update(updateTaskListInfo);
            context.SaveChanges();

            return context.SubTasks.FirstOrDefault(x => x.Id == tmpNewtaskList.Id);
        }
    }
}
