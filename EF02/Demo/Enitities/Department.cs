using System.ComponentModel.DataAnnotations.Schema;

namespace Session_01.Enitities;

public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; } 
    public double Salary { get; set; }
    public int Age { get; set; }

    /*
     * A navigation property is a property on an entity that holds a reference to another entity or a collection of entities.
     * It is used to define relationships between entities and to navigate those relationships
     */    

    // [ForeignKey("Manager")] // Foreign Key [Manager] is a Navigation Property in Employee Class

    public Employee Manager { get; set; } // Navigation Property [one to one]: This means each Department is associated with one Employee, and vice versa.

    public List<Employee> Employees { get; set; } // Navigation Property [one to to meny]: This means each Department is associated with one Employee, and vice versa.

}