using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Session_01;

[Table("Employeee", Schema = "dbo")] // Change Table Name 
public class Employee
{
    /*
     * EF Core Support 4 ways For Mapping Classes in Database (Table, View, Function)
     *  - 01 By Convention (Default Behavior)
     *  - 02 By Data Annotation
     *  - 03 By Fluent API
     *  - 04 By Using Attributes
     */
    
    /*
     *  POCO CLass (Plain Old CLR Object)
     * That Class Not Contains Any Functionality Just Properties
     */

    #region By Convention

    /*
     * EF Core By Convention Will Consider This Property As Primary Key.
     * The Property Name Is Id Or ClassNameId.
     * Must be Numeric Type.
     * If You Want To Change The Name Of The Primary Key You Can Use Data Annotation.
     * if the property Is Reference Type  Make it Allow Null
     * if the property Is Value Type  Not Allow Null
     */ 
    
    // public int Id { get; set; }
    // public string? Name { get; set; } // NVARCHAR(MAX) : Reference Type: Make it Allow Null in Database 
    // public double Salary { get; set; } // float: Value Type: Not Allow Null in Database
    // public int Age { get; set; }

    #endregion

    #region Data Annotation (Set Of Attributes Used Data Validation)
    /*
     * Data Annotation: Is Attributes That You Can Add It To The Class Or Property To Change The Default Behavior.
     * Data Annotations can be used for both validation and database schema configuration.
     *  - Validation: Data Annotations can be used to enforce validation rules on the properties of a class. For example, [Required], [MaxLength], and [Range] are used to validate data before it is saved to the database.
     *  - Database Schema Configuration: Data Annotations can also be used to configure the database schema. For example, [Key], [DatabaseGenerated], and [Column] are used to define primary keys, auto-increment fields, and column names/types.
     * 
     */
    
    // Database Schema Configuration
    [Key] // Primary Key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment
    public int Id { get; set; }

    // Validation
    [Required] // Not Null
    [MaxLength(50)] // Maximum Length
    public string Name { get; set; }

    [Column(TypeName = "money")] // Change Data Type
    [Range(0, double.MaxValue)] // Range Validation
    public double Salary { get; set; }

    // Validation
    [Range(18, 65)] // Range Validation
    public int Age { get; set; }

    [Phone] // Phone Number Validation 
    public string Phone { get; set; }

    [EmailAddress] // Email Validation
    public string Email { get; set; }

    [NotMapped] // Not Save In Database
    public string address { get; set; }
    #endregion
 

}