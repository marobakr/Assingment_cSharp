using System.ComponentModel.DataAnnotations;
using Company.S03.DAL.Models;

namespace Company.S03.PL.ViewModels.Employee;

public class EmployeeViewModel
{
    public int  Id { get; set; }
    [Required(ErrorMessage = "Employee name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Salary is required")]
    [DataType(DataType.Currency)]
    public decimal Salary { get;  set; }
    [RegularExpression(@"^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$", ErrorMessage = "Address Must be Like 123-Street-City-Country")]
    public string Address { get; set; }
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }
    [Phone(ErrorMessage = "Invalid Phone Number")]
    public string PhoneNumber { get; set; }
    public int? Age { get; set; }
    public bool IsActive { get; set; }
    public DateTime HiringDate  { get; set; }
 
    public int? WorkForId { get; set; } // Foreign Key
    public Department? WorkFor { get; set; } // Navigation Property
}