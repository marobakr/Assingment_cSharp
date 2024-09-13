using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Session_01.Enitities;

namespace Session_01;

[Table("Employeee", Schema = "dbo")] // Change Table Name and determine Schema
public class Employee
{

     public int Id { get; set; }
     public string? Name { get; set; } /* Convert To NVARCHAR(MAX) : Reference Type: Make it Allow Null in Database */ 
     public double Salary { get; set; } /* Convert To float: Value Type: Not Allow Null in Database */
     public int Age { get; set; }
     
     /* This means each Employee is associated with one Department, and vice versa. */
     // [InverseProperty(nameof(Enitities.Department.Age))] //  
     public Department Department { get; set; } // Navigation Property [One to One] [One Department has One Manager] Relationship 


  
}