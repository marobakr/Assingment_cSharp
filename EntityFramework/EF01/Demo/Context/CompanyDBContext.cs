using Microsoft.EntityFrameworkCore;
using Session_01.Configrations;

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
        #region Use Fluent API To Configure The Model
        modelBuilder.Entity<Employee>().HasKey((E) => E.Id); // Add Primary Key
        modelBuilder.Entity<Employee>().Property((E) => E.Id).UseIdentityColumn(1, 1); // Auto Increment: Add Identity constraint
        modelBuilder.Entity<Employee>().Property((E) => E.Name).IsRequired().HasMaxLength(50).HasDefaultValue("marwan"); // Not Null: Add Required constraint and Maximum Length and default value
        
        
        /* Or */
        modelBuilder.Entity<Employee>(E =>
        {

            E.HasKey((E) => E.Id); // Add Primary Key
            E.Property((E) => E.Salary).HasColumnType("money").IsRequired().HasDefaultValue(0); // Change Data Type: Add Column Type and Not Null and default value
            E.Property((E) => E.Age).IsRequired().HasDefaultValue(18); // Not Null: Add Required constraint and default value
            E.Property((E) => E.Phone).IsRequired().HasMaxLength(15); // Not Null: Add Required constraint and Maximum Length
            E.Property((E) => E.Email).IsRequired().HasMaxLength(50); // Not Null: Add Required constraint and Maximum Length
            E.Property((E) => E.address).HasMaxLength(100); // Maximum Length
        }) ;

        #endregion
        
        #region  Class Configuration (Open EmployeeConfig.cs)
        modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfig());
        // modelBuilder.ApplyConfigurationsFromAssembly() // for apply all configurations in the assembly
        #endregion
  
        base.OnModelCreating(modelBuilder);
    }

    /*
     * 01- create class for make table in database
     * 02- DbSet<Class> Class { get; set; } // for make table in database
     * 03 make migrations and then update database
     * after each change in the class must make migrations and update database
     * if you wanna back to the previous migration use this command must
     *  - update the database to the previous migration
     * - thne remove the last migration then make new migration or update the database
     */
    public DbSet<Employee> Employees { get; set; } // for make table in database
}
