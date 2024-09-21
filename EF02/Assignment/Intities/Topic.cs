namespace Assignment.Intities;

public class Topic
{
    public int Id { get; set; }
    public string name { get; set; }
    public Instructor Instructor  { get; set; } // Navigation Property 

}