
namespace TestShapeArea;

public class QuadrilateralValidator : IPolygonValidator
{
    public void Validate(List<Edge> edges)
    {
        if (edges.Count != 4)
        {
            throw new Exception("Wrong amount of edges for Quadrilateral");
        }
    }

    public void Validate(List<Vertice> vertices)
    {
        if (vertices.Sum(vertice => vertice.Angle.Degree) != 360)
        {
            throw new Exception("Wrong total sum of angles for Quadrilateral");
        }
    }
}
