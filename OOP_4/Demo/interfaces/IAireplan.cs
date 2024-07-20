namespace Demo.interfaces;

public class Aireplan :Imoveble , iFlyable 
{
    void Imoveble.Forward()
    {
        Console.WriteLine("Forward");
    }

    void iFlyable.Bckword()
    {
        Console.WriteLine("Bckword");
    }

    void iFlyable.Left()
    {
        Console.WriteLine("left");
    }

    void iFlyable.Right()
    {
        Console.WriteLine("Right");
    }

    void iFlyable.Forward()
    {
        Console.WriteLine("Forward");
    }

    void Imoveble.Bckword()
    {
        Console.WriteLine("Bckword");
    }

    void Imoveble.Left()
    {
        Console.WriteLine("left");
    }

    void Imoveble.Right()
    {
        Console.WriteLine("Right");
    }
}