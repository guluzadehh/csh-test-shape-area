namespace TestShapeArea;

public class TriangleSineAreaCalculator : IPolygonAreaCalculator
{
    public double Compute(Polygon polygon)
    {
        Vertice? vertice = polygon.Vertices.ToList().Find(vertice => vertice.Angle != null)
                            ?? throw new Exception("No angle set to Triangle");

        return vertice.Edges[0].Length * vertice.Edges[1].Length * Math.Sin(vertice.Angle!.InRadians) / 2;
    }
}
