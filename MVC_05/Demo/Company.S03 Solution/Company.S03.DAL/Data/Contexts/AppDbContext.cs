using System.Reflection;
using Company.S03.DAL.Data.Configrations;
using Company.S03.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.S03.DAL.Data.Contexts;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //         
    //     optionsBuilder.UseSqlServer(
    //         "Server=localhost;Database=G3;User Id=sa;Password=marwan1739258  1739258!!hero;");
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new DepartmentConfigurations()); //! This line will apply the configuration of the Department entity
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //* This line will apply all configurations in the same assembly
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

}