using System.Reflection;
using fluentApi.Configs;
using Microsoft.EntityFrameworkCore;

namespace fluentApi;

public class MyContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserAtt> UserAtt { get; set; }
    public DbSet<UserFluent> UserFluents { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=StudentBromand;Integrated Security=true;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new UserFluentConfig());
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
       //  modelBuilder.Entity<UserFluent>(d =>
       //  {
       // d.ToTable("MyUserFluents");
       // d.HasKey(d => d.Id);
       // d.Property(d => d.Id).ValueGeneratedOnAdd();
       // d.Property(d => d.Age).IsRequired();
       // d.Property(d=>d.BirthDate).IsRequired();
       //  });
        base.OnModelCreating(modelBuilder);
    }
}