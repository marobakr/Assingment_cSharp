using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Intities;

public class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Fname { get; set; }

    [Required, MaxLength(50)]
    public string Lname { get; set; }

    [Required, MinLength(10)]
    public string Address { get; set; }

    [Required]
    public int Age { get; set; }

    public int Dep_id { get; set; }
    
    public List<Course> Course { get; set; } // Many to Many Relationship
}