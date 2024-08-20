namespace Assignment;

public class Department
{
    public int DeptID { get; set; }
    public string DeptName { get; set; }

    List<Employee> Staff = new List<Employee>();

    public void AddStaff(Employee e)
    {
        Staff.Add(e);
        e.EmployeeLayOff += RemoveStaff;
    }

    public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
    {
        Employee emp = (Employee) sender  ;
        if (e.Cause == LayOffCause.Age || e.Cause == LayOffCause.VacationStock)
        {
            Staff.Remove(emp);
        }
    }
}
