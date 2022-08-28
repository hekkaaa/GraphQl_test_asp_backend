using GraphQlServer.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQlServer.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Bond> Bonds { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");
        }
    }
}
