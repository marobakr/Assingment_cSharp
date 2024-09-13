using System.Security.Cryptography.X509Certificates;
using Assignment.Configrations;
using Assignment.Intities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Assignment.Context;

public class ITIDBContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=newITI;User Id=sa;Password=marwan1739258  1739258!!hero;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Use Fluent API To Configure The Model For Topic Entity
        modelBuilder.Entity<Topic>().HasKey((T) => T.Id); // Add Primary Key
        modelBuilder.Entity<Topic>().Property((T) => T.name).IsRequired();   // Not Null: Add Required constraint
        #endregion

        #region Use Fluent API To Configure The Model For Department Entity

        modelBuilder.Entity<Department>(D =>
        {
            D.Property((D) => D.Id).IsRequired();
            D.HasKey((D) => D.Id);
            D.Property((D) => D.ins_id).HasMaxLength(30);
        });
        

        // modelBuilder.Entity<Department>().Property((E) => E.Id).UseIdentityColumn(1, 1); // Auto Increment: Add Identity constraint
        // modelBuilder.Entity<Department>().Property((E) => E.name).IsRequired().HasMaxLength(50).HasDefaultValue("marwan"); // Not Null: Add Required constraint and Maximum Length and default value
        // modelBuilder.Entity<Department>().Property((E) => E.ins_id).IsRequired().HasDefaultValue(0); // Not Null: Add Required constraint and default value
        // modelBuilder.Entity<Department>().Property((E) => E.HiringDate).IsRequired().HasDefaultValue(DateAndTime.Now); // Not Null: Add Required constraint and default value
        
        // modelBuilder.Entity<stud_course>().HasKey((E) => E.st_Id); // Add Primary Key
        // modelBuilder.Entity<stud_course>().Property((E) => E.st_Id).UseIdentityColumn(1, 1); // Auto Increment: Add Identity constraint
        // modelBuilder.Entity<stud_course>().Property((E) => E.Grade).IsRequired().HasDefaultValue(0); // Not Null: Add Required constraint and default value
        // modelBuilder.Entity<stud_course>().Property((E) => E.Course_di).IsRequired().HasDefaultValue(0); // Not Null: Add Required constraint and default value
        
        // modelBuilder.Entity<Topic>().HasKey((E) => E.Id); // Add Primary Key
        // modelBuilder.Entity<Topic>().Property((E) => E.Id).UseIdentityColumn(1, 1); // Auto Increment: Add Identity constraint
        // modelBuilder.Entity<Topic>().Property((E) => E.name).IsRequired().HasMaxLength(50).HasDefaultValue("marwan"); // Not Null: Add Required constraint and Maximum Length and default value
        #endregion
        
        #region  Class Configuration For Instructor Entity (Open InstructorConfig.cs)

        modelBuilder.ApplyConfiguration<Instructor>(new InstrcutorConfig());
        #endregion
        
    }
    /*
     * 01- create class for make table in database
     * 02- DbSet<Class> Class { get; set; } // for make table in database
     * 03 make migrations and then update database
     */
    public DbSet<Instructor> Instructors { get; set; } 
    public DbSet<Topic> Topic { get; set; } 
    public DbSet<Course> Course { get; set; } 
    public DbSet<Department> Department { get; set; } 
    public DbSet<Course_ins> Course_ins { get; set; } 
    public DbSet<Student> Student { get; set; } 

}