namespace Session_4;

 class Parent
 {

     private int salary;

     public virtual int Salary
     {
         get => salary; set => salary = value - 100;
     }
    
public virtual void  Print() => Console.WriteLine("Hello Arrow Function [gos to]");
         
}
 class Child: Parent
{ 
    /* Sealed Method */
    public sealed override void Print() =>  Console.WriteLine("hello Child");

    public sealed override int Salary
    {
        get => Salary;
        set => Salary = value + 2000;
    }
}
 sealed class GrandChild: Child
{
    // public override void Print() =>  Console.WriteLine("hello GrandChild"); // invalid  Override

    // public override int Salary // invalid  Override
    // {
    //     get => Salary;
    //     set => Salary = value + 500;
    // }
}
// class GrandGrandChild : GrandChild {} // invalid Inheritance 

