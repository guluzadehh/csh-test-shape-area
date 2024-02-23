namespace TestShapeArea;

public class TriangleValidator : IPolygonValidator
{
    public void Validate(List<Edge> edges)
    {
        if (edges.Count != 3)
        {
            throw new Exception("Wrong amount of edges for Triangle");
        }
    }

    public void Validate(List<Vertice> vertices)
    {
        if (vertices.Sum(vertice => vertice.Angle.Degree) != 180)
        {
            throw new Exception("Wrong total sum of angles for Triangle");
        }
    }
}
