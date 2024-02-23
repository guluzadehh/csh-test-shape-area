namespace TestShapeArea;

public class Polygon : IShape
{
    public virtual string Name { get; } = "Polygon";

    public virtual IPolygonAreaCalculator AreaCalculator { get; set; }
    public double Area { get { return AreaCalculator.Compute(this); } }

    public List<Edge> Edges { get; set; }
    public List<Vertice> Vertices { get; set; } = [];
    public virtual IPolygonValidator Validator { get; set; }

    public Polygon(List<Edge> edges)
    {
        Validator?.Validate(edges);
        Edges = edges;
    }

    public Polygon(List<Edge> edges, List<Vertice> vertices) : this(edges)
    {
        Validator?.Validate(vertices);
        Vertices = vertices;
    }

    public override string? ToString()
    {
        return $"{Name} ({string.Join(',', Edges.Select(edge => edge.Length))})";
    }
}