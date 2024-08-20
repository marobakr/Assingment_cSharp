namespace Assignment;
public class Employee
{
    public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

    protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
    {
        EmployeeLayOff?.Invoke(this, e);
    }

    public int EmployeeID { get; set; }

    public DateTime BirthDate { get; set; }

    public int VacationStock { get; set; }

    public bool RequestVacation(DateTime from, DateTime to)
    {
        return true;
    }

    public void EndOfYearOperation()
    {
        if (VacationStock < 0)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStock });
        }
        if (Age > 60)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Age });
        }
    }

    public int Age => DateTime.Now.Year - BirthDate.Year;
}

public enum LayOffCause
{
    Age,
    VacationStock,
    TargetNotAchieved,
    Resigned
}

public class EmployeeLayOffEventArgs : EventArgs
{
    public LayOffCause Cause { get; set; }
}
