using TestShapeArea;

namespace TestShapeLib
{
    public class RectangleAreaCalculator : IPolygonAreaCalculator
    {
        public double Compute(Polygon polygon)
        {
            RectangleValidator validator = new();
            validator.Validate(polygon.Edges);
            validator.Validate(polygon.Vertices);
            return polygon.Edges[0].Length * polygon.Edges[1].Length;
        }
    }
}