namespace TestShapeArea;

public class Vertice
{
    public Angle Angle { get; set; }
    public Edge[] Edges { get; set; }

    public Vertice(Edge e1, Edge e2, Angle angle)
    {
        if (e1 == e2)
        {
            throw new Exception("Wrong vertice edges joined");
        }

        Edges = new Edge[2];
        Edges[0] = e1;
        Edges[1] = e2;
        Angle = angle;
    }
}