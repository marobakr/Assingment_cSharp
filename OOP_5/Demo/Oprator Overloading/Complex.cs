namespace Session_4.Oprator_Overloading;

public class Complex
{
    public int Real { get;set; }

    public int Image { get;set; }

    public override string ToString()
    {
        return $"{Real} + {Image}i";
    }

    #region Overloading
    // Operator Overloading : must be  public Class member Method 
    public static Complex operator +(Complex left, Complex right)
    {
        return new Complex()
        {
            Real = (left?.Real ?? 0) + (right?.Real ?? 0),
            Image =( left?.Image ?? 0) + (right?.Image ?? 0)
        };
    }
    public static Complex operator -(Complex left, Complex right)
    {
        return new Complex()
        {
            Real = (left?.Real ?? 0) - (right?.Real ?? 0),
            Image =( left?.Image ?? 0) - (right?.Image ?? 0)
        };
    }
    public static Complex operator ++(Complex C)
    {
        
        if (C is not null)
        {
         C.Real++;
        }

        return C;
// Or Return New Object 
        // return new Complex()
        // {
        //     Real = C?.Real ?? 0 + 1,
        //     Image = C?.Image ?? 0,
        //
        // };
    }
    public static bool operator > (Complex left, Complex right)
    {
        if (left?.Real == right?.Real)
            return left?.Image > right.Image;
        else
            return left?.Real > right?.Real;
    }
    public static bool operator < (Complex left, Complex right)
    {
        if (left?.Real == right?.Real)
            return left?.Image < right.Image;
        else
            return left?.Real < right?.Real;
    }
    public static explicit operator int(Complex C)
    {
        return C.Real;
    }
    public static implicit operator string(Complex C)
    {
        return C?.ToString() ?? " ";
    }

    #endregion
}