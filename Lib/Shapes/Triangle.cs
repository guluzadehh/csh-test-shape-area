namespace TestShapeArea;

public class Triangle : Polygon
{
    public override string Name { get; } = "Triangle";
    public override IPolygonAreaCalculator AreaCalculator { get; set; } = new TriangleHeronAreaCalculator();
    public IPolygonValidator Validator { get; set; } = new TriangleValidator();

    public bool IsPrimary
    {
        get
        {
            Edge hypothenuse = Edges.MaxBy(edge => edge.Length)!;
            Edge[] catets = Edges.Where(edge => edge != hypothenuse).ToArray();
            return Math.Pow(catets[0].Length, 2) + Math.Pow(catets[1].Length, 2) == Math.Pow(hypothenuse.Length, 2);
        }
    }

    public Triangle(List<Edge> edges) : base(edges)
    {
    }

    public Triangle(List<Edge> edges, List<Vertice> vertices) : base(edges, vertices)
    {
    }
}
