namespace Assignment;

public class SalesPerson : Employee
{
    public int AchievedTarget { get; set; }

    public bool CheckTarget(int Quota)
    {
        if (AchievedTarget < Quota)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.TargetNotAchieved });
            return false;
        }
        return true;
    }
}
