using Microsoft.EntityFrameworkCore;
using Models.User;
namespace Db.ApplicationContext;
public class ApplicationContext : DbContext
{
 public DbSet<User> Users => Set<User>();
 public ApplicationContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source =taskmanager.db");
    }
}