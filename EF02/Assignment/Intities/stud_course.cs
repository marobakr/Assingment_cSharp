using System.ComponentModel.DataAnnotations;

namespace Assignment.Intities;

public class stud_course
{
    [Key] // Convert To PK in Database
    public int stud_course_Id { get; set; }

    [Required]
    public int Grade { get; set; } // Convert To NOT NULL in Database

    public int? Course_id { get; set; } // Convert Apply Null  
    public List<Student> Students { get; set; }

}