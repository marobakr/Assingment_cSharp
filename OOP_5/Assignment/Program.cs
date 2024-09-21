namespace Assignment;
/* ===================== Assignment 04 =====================*/

class Program
{
    static void Main(string[] args)
    {
        #region First Project:
        //
        // Point3D point3D = new Point3D(1, 2, 3);
        // Console.WriteLine(point3D.ToString());
        //
        // int P1;
        // int P2;
        // Console.WriteLine("Enter coordinates for P1 :");
        // int.TryParse(Console.ReadLine(), out P1);
        // Console.WriteLine("Enter coordinates for P2 :");
        // int.TryParse(Console.ReadLine(), out P2);
        // Console.WriteLine(P1 == P2 ? "P1 and P2 are equal." : "P1 and P2 are not equal.");
        //
        // /* Clone*/
        // Point3D clonedPoint;
        // clonedPoint = (Point3D) point3D.Clone();
        // Console.WriteLine("Cloned Point: " + clonedPoint.ToString());
        //
        //
        // Point3D[] Point3D =
        // {
        //     new Point3D() { P1 = 20, P2 = 50, P3 = 5000 },
        //     new Point3D() { P1 = 40, P2 = 90, P3 = 200 },
        //     new Point3D() { P1 = 20, P2 = 54, P3 = 3000 },
        // };
	       //
        // int Result = Point3D[0].CompareTo(Point3D[1]);
        // Console.WriteLine($"this result is a: {Result} ");
        //
        #endregion

        #region Second Project:
        //
        // int add = Maths.Add(10, 8);
        // int multiply = Maths.Multiply(50, 80);
        // int divide = Maths.Divide(50, 80);
        // int subtract = Maths.Subtract(50, 80);
        //
        // Console.WriteLine($"add {add}");
        // Console.WriteLine($"multiply {multiply}");
        // Console.WriteLine($"divide {divide}");
        // Console.WriteLine($"subtract {subtract}");
        #endregion

        #region Third Project
        Duration d1 = new Duration(1, 10, 15);
        Console.WriteLine(d1.ToString()); 

        Duration d2 = new Duration(3600);
        Console.WriteLine(d2.ToString());

        Duration d3 = new Duration(7800);
        Console.WriteLine(d3.ToString()); 

        Duration d4 = new Duration(11, 6);
        Console.WriteLine(d4.ToString()); 
        
        #endregion
    }
}