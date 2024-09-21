namespace session_4.FiFA;

public struct Location : IEquatable<Location>
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public override string ToString()
    {
        return $"Location: X={X}, Y={Y}, Z={Z}";
    }

    public bool Equals(Location other)
    {
        return X == other.X && Y == other.Y && Z == other.Z;
    }
}
