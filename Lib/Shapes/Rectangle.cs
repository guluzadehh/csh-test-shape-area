
using TestShapeLib;

namespace TestShapeArea;

public class Rectangle : Polygon
{
    public override string Name { get; } = "Rectangle";

    public override IPolygonAreaCalculator AreaCalculator { get; set; } = new RectangleAreaCalculator();
    public override IPolygonValidator Validator { get; set; } = new RectangleValidator();

    public Rectangle(List<Edge> edges) : base(edges)
    {
        Vertices.Add(new Vertice(edges[0], edges[1], new Angle(90)));
        Vertices.Add(new Vertice(edges[1], edges[2], new Angle(90)));
        Vertices.Add(new Vertice(edges[2], edges[3], new Angle(90)));
        Vertices.Add(new Vertice(edges[3], edges[0], new Angle(90)));
    }
}
