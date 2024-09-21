using Microsoft.EntityFrameworkCore;
using Session_03.Inheritance.Models;

namespace Session_03.Inheritance.Context;

public class AppDbContext:DbContext
{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=G3;User Id=sa;Password=marwan1739258  1739258!!hero;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPC [table per class]
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees"); 
            #endregion
            
            #region TPCC
            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
            #endregion
            base.OnModelCreating(modelBuilder);
        }


        public  DbSet<Employee> Employees { get; set; }
        
        #region TPC [table per class] && TPH
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion

    }

