using Microsoft.EntityFrameworkCore;
using Session_03.Inheritance.Context;
using Session_03.Inheritance.Models;

namespace Session_03;

class Program
{ 
   static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
            #region Inheritance
            using AppDbContext appAppDbContext = new AppDbContext();

            #region TPC[Table Per  Class]
            
            // FullTimeEmployee employee01 = new FullTimeEmployee() { Name = "Marwan", Address = "alex", Email = "dev@dev.com", Salary = 20000 };
            // FullTimeEmployee employee02 = new FullTimeEmployee() { Name = "Marwan", Address = "alex", Email = "dev@dev.com", Salary = 20000 };
            // FullTimeEmployee employee03 = new FullTimeEmployee() { Name = "Marwan", Address = "alex", Email = "dev@dev.com", Salary = 20000 };
            // FullTimeEmployee employee04 = new FullTimeEmployee() { Name = "Marwan", Address = "alex", Email = "dev@dev.com", Salary = 20000 };
            //
            // appAppDbContext.Employees.Add(employee03);
            // appAppDbContext.Employees.Add(employee04);
            // appAppDbContext.SaveChanges(); 
            
            #endregion
            
            #region TPH
            // FullTimeEmployee employee = new FullTimeEmployee() { Name = "marwan", Address = "address", Email = "kdkdkdk@gsgs.com", Salary = 20000 };
            // FullTimeEmployee employee02 = new FullTimeEmployee() { Name = "marwan", Address = "alex", Email = "dev@dev.com", Salary = 10000 };
            // PartTimeEmployee employee03 = new PartTimeEmployee() { Name = "marwan", Address = "alex", Email = "dev@dev.com", HourRate = 1000 };
            // PartTimeEmployee employee04 = new PartTimeEmployee() { Name = "marwan", Address = "alex", Email = "dev@dev.com", HourRate = 1000 };
            // appAppDbContext.Employees.Add(employee03);
            // appAppDbContext.Employees.Add(employee04);
            // appAppDbContext.Employees.Add(employee);
            // appAppDbContext.Employees.Add(employee02);
            // appAppDbContext.SaveChanges(); 
            #endregion

            #region TPCC
          //
          //   FullTimeEmployee employee = new FullTimeEmployee() { Name = "Marwan", Address = "address", Email = "  dev@dev.com", Salary = 30000 };
          //   FullTimeEmployee employee02 = new FullTimeEmployee() { Name = "Marwan", Address = "address", Email = "dev@dev.com", Salary = 80000 };
          //   PartTimeEmployee employee03 = new PartTimeEmployee() { Name = "Marwan", Address = "address", Email = "dev@dev.com", HourRate = 2000 };
          //   PartTimeEmployee employee04 = new PartTimeEmployee() { Name = "Marwan", Address = "address", Email = "dev@dev.com", HourRate = 3000 };
          //
          // appAppDbContext.Employees.Add(employee03);
          // appAppDbContext.Employees.Add(employee04);
          // appAppDbContext.Employees.Add(employee);
          // appAppDbContext.Employees.Add(employee02);
          // appAppDbContext.SaveChanges(); 
          
       
          #endregion
             
            #endregion
            
            #region Loading Of Navigational
            /*
             *  EF Core Do Not Load Navigational Property By Default
             * Loading To Navigational Property
             *  - 1.Explicit Loading
             *  - 2.Lazy Loading
             *  - 3.Eager Loading
             */
            
            #region 1.Explicit Loading
            // var result = appAppDbContext.Employees.FirstOrDefault(e => e.Id == 2);
            // appAppDbContext.Entry(result).Reference(e=>e.Name).Load();
            // Console.WriteLine(result.Name);
            #endregion
            
            #region 2.Eager Loading
            // var result01 = appAppDbContext.Employees.Include("works_For").FirstOrDefault(e => e.Id == 2);
            // var result = appAppDbContext.Employees.Include(e=>e.Email).Include(e=>e.Email).FirstOrDefault(e => e.Id == 2);
            //
            // Console.WriteLine(result.Name);
            #endregion
            
            #region 3.lazy Loading
            /*
             * 1.implicity
             * 2.install-package proxies
             * 3.UseLazyLoadingProxies =>onConfigurations
             * 4.Make All The entites public
             * 5.Make All Navigation Properties Virtual
             */
            #endregion
            
            #endregion
            
            #region Tracking Vs NoTracking
           
            #region Tracking
            // var result0 = appAppDbContext.Employees.FirstOrDefault(e => e.Id == 2);
            // Console.WriteLine(result0.Name);
            // //TRACKED BY DEFAULT
            // Console.WriteLine(appAppDbContext.Entry(result0).State); // Unchanged Tracking Because It's Tracked
            #endregion
         
            #region NoTracking
            // var result0 = appAppDbContext.Employees.AsNoTracking().FirstOrDefault(e => e.Id == 2);
            // Console.WriteLine(result0.Name);
            // Console.WriteLine(appAppDbContext.Entry(result0).State); 
            #endregion
            
            #endregion
            
            #region Remote Vs Local
            
            #region Local
            
            // appAppDbContext.Employees.Load();
            //
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            // appAppDbContext.Employees.Local.Any();
            #endregion
            
            #region Remote
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any();
            // appAppDbContext.Employees.Any(); 
            #endregion
            #endregion
            
    }
}