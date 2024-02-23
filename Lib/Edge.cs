namespace TestShapeArea;

public class Edge
{
    private double _length;
    public double Length
    {
        get { return _length; }
        set
        {
            if (value < 0) throw new Exception("Negative edge value");
            _length = value;
        }
    }

    public Edge(double length)
    {
        Length = length;
    }
}