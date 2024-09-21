using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace Company.S03.DAL.Models;

public class Department : BaseEntity
{
    [Required(ErrorMessage = "Code is required")]
    public string Code { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    
    [DisplayName("Date Of Creation")]
    [Required(ErrorMessage = "Date is required")]
    public string DateOfCreation { get; set; }
}
