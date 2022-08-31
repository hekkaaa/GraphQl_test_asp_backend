using GraphQlServer.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQlServer.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres").UseLazyLoadingProxies();
        }
    }
}
