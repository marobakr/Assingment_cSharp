namespace Assignment.Intities;

public class stud_course
{
    public int stud_course_Id { get; set; } /* Convert To PK in Database */ 
    public int Grade { get; set; } // Convert To NOT NULL in Database
    public int? Course_id{ get; set; } // Convert Apply Null  
}