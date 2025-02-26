using Microsoft.EntityFrameworkCore;
using Model.User;
public class ApplicationContext : DbContext
{
 public DbSet<User> Users => Set<User>();
 public ApplicationContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source =taskmanager.db");
    }
}