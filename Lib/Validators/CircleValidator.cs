namespace TestShapeArea;

public class CircleValidator
{
    public void Validate(double radius)
    {
        if (radius < 0)
        {
            throw new Exception("Radius can't be less than 0");
        }
    }
}
