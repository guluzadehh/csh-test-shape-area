namespace TestShapeArea;

public class TriangleHeronAreaCalculator : IPolygonAreaCalculator
{
    public double Compute(Polygon polygon)
    {
        TriangleValidator validator = new();
        validator.Validate(polygon.Edges);

        double[] lengths = polygon.Edges.Select(edge => edge.Length).ToArray();

        double s = lengths.Sum() / 2;

        return Math.Sqrt(s * (s - lengths[0]) * (s - lengths[1]) * (s - lengths[2]));
    }
}