namespace session_1;

public struct Employee
{
    public int Id { get; set; }
    public string  Name { get; set; }
    public double Salary { get; set; }

    public override string ToString()
    {
        return $"{Id} :: {Name} :: {Salary:C}";
    }
    public static bool operator == (Employee Left, Employee Right)
    {
        return   (Left.Id == Right.Id) && (Left.Name == Right.Name) && (Left.Salary == Right.Salary);
    }
    public static bool operator != (Employee Left, Employee Right)
    {
        return   (Left.Id != Right.Id) && (Left.Name != Right.Name) && (Left.Salary != Right.Salary);
    }

    public override bool Equals(object? obj)
    {
       Employee passEmp = (Employee)obj; // Explictly Casting
       return (this.Salary == passEmp.Salary) && (this.Id == passEmp.Id) && (this.Name == passEmp.Name);
    }
}