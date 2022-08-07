using Juegos.Infrastructure.Configurations;
using Juegos.Models;
using Microsoft.EntityFrameworkCore;

namespace Juegos.Infrastructure;

public class HobbiesContext : DbContext
{
    public HobbiesContext()
    {

    }


    public HobbiesContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
    }
}

public class HobbiesContextFactory : IDbContextFactory<HobbiesContext>
{

    public virtual HobbiesContext CreateDbContext()
    {
        var options = new DbContextOptionsBuilder().UseSqlServer("Data Source=LAPTOP-BJ6OHHSQ\\SQLEXPRESS;Initial Catalog=Hobbies;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True").Options;
        return new HobbiesContext(options);
    }
}

