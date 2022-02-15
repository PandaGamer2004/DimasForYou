using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1;

public class StoreContext : DbContext
{
    public StoreContext()
    {
        Database.EnsureCreated();
    }
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LearnLinq;Trusted_connection=true");
        base.OnConfiguring(optionsBuilder);
    }
}