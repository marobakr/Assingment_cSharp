using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Intities;

public class Course_ins
{
    /* EF Core By Data Annotation */
    [Key] // Convert To PK in Database
    public int inst_id { get; set; }
    [Required] // Convert To NOT NULL in Database
    public int Course_id { get; set; }
    [NotMapped] // Not Convert To Column in Database
    public string evaluate { get; set; }
}