namespace TestShapeArea;

public class Circle : IShape
{
    public string Name { get; } = "Circle";
    public CircleValidator Validator { get; set; } = new CircleValidator();
    public CircleAreaCalculator AreaCalculator { get; set; } = new CircleAreaCalculator();
    public double Radius { get; set; }

    public double Area
    {
        get
        {
            return AreaCalculator.Compute(Radius);
        }
    }

    public Circle(double radius)
    {
        Validator?.Validate(radius);
        Radius = radius;
    }

    public override string? ToString()
    {
        return $"{Name} ({Radius})";
    }
}