namespace session_1;

class Program
{
    static void Main(string[] args)
    {
        #region GenericsType

        /* ======= Helpers ======= */

        int A = 3;
        int B = 4;

        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");

        Helper<int>.SwapGn(ref A, ref B);

        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");

        /* ======= Point ======= */

        Point p01 = new Point(1, 1);
        Point p02 = new Point(2, 2);

        Console.WriteLine($"p1 = {p01}");
        Console.WriteLine($"p2 = {p02}");

        /* ======= Generics ======= */

        /*
         * in case GenericsType "T" is a Declared on Method Level, NOT CLass , NoT Interface  Not Structure:
         * the Compiler Can Detect the Type of "T" based on Type of Method Input Parameters
         */

        Helper<System.Drawing.Point>.SwapGn<>(ref p01, ref p02);
        Console.WriteLine($"p1 = {p01}");
        Console.WriteLine($"p2 = {p02}");

        #endregion

        #region GenericesExample

        /* SearchArray */
        int[] Number = { 10, 20, 30, 40 };

        int index = Helper<object>.SearchArray(Number, 12);

        Console.WriteLine(index);

        /* SearchArrayGenracis */

        Employee emp01 = new Employee()
        {
            Id = 10,
            Name = "marwan",
            Salary = 1000
        };
        Employee emp02 = new Employee()
        {
            Id = 2,
            Name = "ahmed",
            Salary = 5000
        };
        /* By Default the user Define Struct doesn't have equal equal Oprator   */
        /* By Default the user Define Class have equal equal Oprator */

        if (emp01 == emp02)
        {
            Console.WriteLine("Equals");
        }
        else
            Console.WriteLine("not Equals");

        #endregion

        #region Equality

        Employee employee01 = new Employee()
        {
            Id = 10,
            Name = "x",
            Salary = 500
        };

        Employee employee02 = new Employee()
        {
            Id = 120,
            Name = "x",
            Salary = 5500
        };
        Console.WriteLine($"Employe01 {employee01}");
        Console.WriteLine($"Employe02 {employee02}");
        /* Comparison WIth Address In Stack */
        if (employee01 == employee02)
            Console.WriteLine("equals");
        else
            Console.WriteLine("not equals");
           
        #endregion
    }
}