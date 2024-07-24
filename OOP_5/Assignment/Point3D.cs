namespace Assignment;


/* ============= First Project: ========== */
public class Point3D : ICloneable , IComparable
{
    public int P1 { get; set; }
    public int P2 { get; set; }
    public int P3 { get; set; }

    public Point3D() : this(0, 0, 0)
    {
    }

    public Point3D(int p1, int p2, int p3)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
    }

    public override string ToString()
    {
        return $"Point Coordinates: ({P1},{P2},{P3})";
    }

    public object Clone()
    {
        return new Point3D(P1,P2,P3);
    }

    public int CompareTo(object? obj)
    {
        Point3D passedPoin = (Point3D)obj;
        if (this.P1 > passedPoin.P1)
            return 1;
        else if (this.P2 > passedPoin.P3)
            return -1;
        else return 0;
    }
  
    
}