namespace TestShapeArea;

public class CircleAreaCalculator
{
    public double Compute(double radius)
    {
        CircleValidator validator = new();
        validator.Validate(radius);

        return Math.PI * Math.Pow(radius, 2);
    }
}