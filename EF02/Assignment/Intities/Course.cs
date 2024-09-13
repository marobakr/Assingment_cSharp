namespace Assignment.Intities;

public class Course
{
    /* EF Core By Conventions */
    public int Id { get; set; }  /* Convert To PK in Database */ 
    public int Durations { get; set; }
    public string Name { get; set; }  /* Convert To NVARCHAR(MAX) : Reference Type: Make it Allow Null in Database */ 
    public string Description { get; set; }  /* Convert To NVARCHAR(MAX) : Reference Type: Make it Allow Null in Database */ 
    public string Top_id { get; set; }  /* Convert To NVARCHAR(MAX) : Reference Type: Make it Allow Null in Database */ 


}