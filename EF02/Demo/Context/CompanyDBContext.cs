using Microsoft.EntityFrameworkCore;
using Session_01.Configrations;
using Session_01.Enitities;

namespace Session_01.Context;

public class CompanyDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=G3;User Id=sa;Password=marwan1739258  1739258!!hero;");


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region relation one to one
        /* 02 this will create a column in the database as PK by Fluent API [one to one ] */
        modelBuilder.Entity<Employee>()
            .HasOne(E => E.Department)
            .WithOne(D => D.Manager)
            .HasForeignKey<Department>(D => D.Manager);
        #endregion

    }

    public DbSet<Employee> Employees { get; set; } 
    public DbSet<Department> Departments { get; set; } 
    public DbSet<Course> Course { get; set; } 
    public DbSet<Students> Students { get; set; } 
}

