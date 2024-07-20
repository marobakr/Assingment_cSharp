namespace Demo.interfaces;

public interface IMyType
{
    /*
     * Interface is a code contract
     * can I Create Reference Form Interface
     * I can't Create Object From Interface
     * Default Access Modifier Inside Interface iS a Public

    */
    //   1- Signature For Property
    int Salary { get; set; }
    // 2- Signature For Mehtod 
    void MyFUn();
    // 3- defaults Implemented Mouthed C# 8.0 [.NET CORE 3.1]
    void Print()
    {
        Console.WriteLine("hello form Defuel Method ");
    }
}

class MyClass : IMyType
{
    // dynamic Property
    public int Salary { get; set; }
    public  void MyFUn() =>   Console.WriteLine("hello route");
}