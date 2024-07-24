namespace Session_4;

public abstract class Shape
{
    public decimal Dim01 { get; set; }
    public decimal Dim02 { get; set; }

    // abstract Property Like A Virtual Property Without Implementation
    public abstract decimal Perimeter
    {
        get;
    }
    // abstract Method Like A =  Virtual Method Without Implementation
    public abstract decimal CalcArea(); 

}

public abstract class RectBase : Shape {
    public override decimal CalcArea()
    {
        return Dim01 * Dim02;
    }
}
    
/* ========= Concrete Class ========= */
public class Rect : RectBase
{
    public override decimal Perimeter
    {
        get { return (Dim01 + Dim02) * 2; }
    }
}

/* ========= Concrete Class ========= */
public class Square : RectBase
{
    public Square(decimal Dim)
    {
        Dim01 = Dim02 = Dim;
    }

    public override decimal Perimeter
    {
        get { return Dim01 * 4; }
    }

  
}

/* ========= Concrete Class ========= */
public class Circle : Shape {
    public Circle(decimal Radius)
    {
        Dim01 = Dim02 = Radius;
    }
    public override decimal Perimeter
    {
        get { return 2 * 3.14M * Dim01; }
    }
    public override decimal CalcArea()
    {
        return 3.14M * Dim01 * Dim02;
    }
}