namespace Session_01.Enitities;

public class Course
{
    public int  Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Students> Students { get; set; }
}