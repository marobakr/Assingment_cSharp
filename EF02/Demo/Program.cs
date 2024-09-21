using Microsoft.EntityFrameworkCore;
using Session_01.Context;

namespace Session_01;

class Program
{
    static void Main(string[] args)
    {
/*
      * EF Core: ORM in .NET
      * ORM: Object Relational Mapping
      * ORM Use for:
      * -1 Mapping (Code first [Generate Table Per Class] OR [Database first (Generate Class Per Table])
      * -2 LINQ [C# Code (LINQ)] Convert to SQL Query
      */

        #region Crude Operation [Create, Read, Update, Delete]
            // context.Dispose();// Close Connection to Database
          
            using  CompanyDbContext context = new CompanyDbContext();

            #region Create

            var employee = new Employee()
            {
                Age = 40,
                Name = "Marwan",
                Salary = 4000,
            };
            /*
             Added	4	
               The entity is being tracked by the context but does not yet exist in the database.
               
               Deleted	2	
               The entity is being tracked by the context and exists in the database. It has been marked for deletion from the database.
               
               Detached	0	
               The entity is not being tracked by the context.
               
               Modified	3	
               The entity is being tracked by the context and exists in the database. Some or all of its property values have been modified.
               
               Unchanged	1	
               The entity is being tracked by the context and exists in the database. Its property values have not changed from the values in the database.
             */
            
            /* this command like command line for Git */
            Console.WriteLine(context.Entry(employee).State);//  [Detached]
           
            /*Or*/
            // context.Add(employee); // Add Employee to Context
            context.Entry(employee).State = EntityState.Added; // Manually Add Employee to Context  
            context.Employees.Add(employee); // Add Specific object Context 
            
            Console.WriteLine(context.Entry(employee).State);// [Added] like tracking in Git
            context.SaveChanges(); // Save Changes
            Console.WriteLine(context.Entry(employee).State);// [Unchanged]
            employee.Name = "omar";
            Console.WriteLine(context.Entry(employee).State);// [Modified]
            



            #endregion

            #region Read

            var Result  =  context.Employees.Where((E) => E.Id == 2);
            Console.WriteLine(Result.ToList()[0].Name);
            
            
            #endregion


            #region Update

            /*
             * before update, you must get the object from the database then update it
             */
            var Result01 = context.Employees.FirstOrDefault(E => E.Id == 2);
            Result01.Name = " mohamed";
            Console.WriteLine(context.Entry(employee).State);
            context.SaveChanges();
            Console.WriteLine(context.Entry(employee).State);


            #endregion


            #region Delete
                
           var ResultDelated = context.Employees.FirstOrDefault(E=>E.Id == 1);
           Console.WriteLine(context.Entry(ResultDelated).State); // [unchanged]
           context.Remove(ResultDelated);
           Console.WriteLine(context.Entry(ResultDelated).State); // [Deleted]
           context.SaveChanges(); // that make the database like memory
           Console.WriteLine(context.Entry(ResultDelated).State); // [Detached || Untracked]


           #endregion

           #endregion

    }
}

