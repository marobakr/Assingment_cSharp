namespace Assignment;
public class Club
{
    public int ClubID { get; set; }
    public string ClubName { get; set; }

    List<Employee> Members = new List<Employee>();

    public void AddMember(Employee e)
    {
        Members.Add(e);
        e.EmployeeLayOff += RemoveMember;
    }

    public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
    {
        Employee emp = sender as Employee;
        if (e.Cause == LayOffCause.VacationStock)
        {
            Members.Remove(emp);
        }
    }
}
