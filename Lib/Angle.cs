namespace TestShapeArea;

public class Angle
{
    private double _degree;
    public double Degree
    {
        get
        {
            return _degree;
        }
        set
        {
            if (value > 360) throw new Exception("Wrong angle value");
            _degree = value;
        }
    }

    public Angle(double degree)
    {
        Degree = degree;
    }

    public bool IsRight { get { return Degree == 90; } }
    public bool IsAcute { get { return Degree < 90; } }
    public bool IsObtuse { get { return Degree > 90; } }

    public double InRadians
    {
        get
        {
            return Degree * Math.PI / 180;
        }
    }
}