namespace TestShapeArea;

public interface IPolygonValidator
{
    void Validate(List<Edge> edges);
    void Validate(List<Vertice> vertices);
}