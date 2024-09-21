namespace Assignment;

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1950, 1, 1), VacationStock = 5 };
        Employee emp2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1985, 1, 1), VacationStock = -1 };
        
        Department department = new Department { DeptID = 101, DeptName = "Sales" };
        department.AddStaff(emp1);
        department.AddStaff(emp2);

        emp1.EndOfYearOperation();
        emp2.EndOfYearOperation();
        

        Club club = new Club { ClubID = 201, ClubName = "Executive Club" };
        club.AddMember(emp1);
        club.AddMember(emp2);

        emp1.EndOfYearOperation();
        emp2.EndOfYearOperation();

        SalesPerson sp = new SalesPerson { EmployeeID = 3, BirthDate = new DateTime(1990, 1, 1), AchievedTarget = 80 };
        sp.CheckTarget(100); 

        BoardMember bm = new BoardMember { EmployeeID = 4, BirthDate = new DateTime(1940, 1, 1) };
        bm.Resign();


    
    }
}