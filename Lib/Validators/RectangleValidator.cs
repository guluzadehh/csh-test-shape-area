
namespace TestShapeArea;

public class RectangleValidator : QuadrilateralValidator
{
    public void Validate(List<Edge> edges)
    {
        if (edges.Select(edge => edge.Length).ToHashSet().Count != 2)
        {
            throw new Exception("Wrong edges lengths for Rectangle");
        }
    }

    public void Validate(List<Vertice> vertices)
    {
        if (vertices.Find(vertice => vertice == null || !vertice.Angle.IsRight) != null)
        {
            throw new Exception("Wrong angle value for Rectangle");
        }
    }
}
