namespace Demo.interfaces;
public class Employee :ICloneable , IComparable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    /* Empty Paramter Less Constructor*/
    public Employee () {}

    public override string ToString()
    {
        /*
         * you can write with keyword this or not
         * this is referred to which will cal this class
         */
        return $"{this.Id} :: {this.Salary:C} :: {this.Name}";
    }
    
    /*
     * Deep Copy With Clonable
     */
    public object Clone()
    {
        return new Employee()
        {
            Id = this.Id,
            Name = this.Name,
            Salary = this.Salary,

        };
    }
    
    /*
     * Deep Copy With Constractor : is a Special Constracotr Used To
     */
    public Employee(Employee employee)
    {
        this.Id = employee.Id;
        this.Salary = employee.Salary;
        this.Name = employee.Name;
    }
    
    
    /* - CompareTo
     * return Positive Number  : this.Salary > obj.Salary
     * return Nigative Number  : this.Salary < obj.Salary
     * Return 0 : this.salary = obj.Salary

     */
    /*
     * this : عايده علي الاوبجكت الي عمل كووول للميثود
     */
    public int CompareTo(object? obj)
    {
        /* Explistly Casting */
        Employee passedEmp = (Employee)obj;
        if (this.Salary > passedEmp.Salary)
            return 1;
        else if (this.Salary > passedEmp.Salary)
            return -1;
        else return 0;
    }
}