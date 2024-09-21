namespace Session_01.Enitities;


public class Students
{
    public int  Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    
    public List<Course> Course { get; set; } // Many to Many Relationship
}