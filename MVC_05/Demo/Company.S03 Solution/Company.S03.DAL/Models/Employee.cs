using System.ComponentModel.DataAnnotations;

namespace Company.S03.DAL.Models;

public class Employee : BaseEntity
{
    public string Name { get; set; }
    public decimal Salary { get;  set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int? Age { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime HiringDate  { get; set; }
    public DateTime DateOfCreation { get; set; } = DateTime.Now;
    public int? WorkForId { get; set; } // Foreign Key
    public Department? WorkFor { get; set; } // Navigation Property
}