using TestShapeArea;

Edge a = new(5);
Edge b = new(12);
Edge c = new(13);

Triangle triangle = new Triangle(new List<Edge>() { a, b, c });
Console.WriteLine($"{triangle} area = {triangle.Area}");

// Try with different Area Calculator
Vertice vertice = new(a, b, new Angle(90));
triangle.Vertices.Add(vertice);
triangle.AreaCalculator = new TriangleSineAreaCalculator();
Console.WriteLine($"{triangle} area = {triangle.Area}");

Console.WriteLine($"{triangle} is right triangle = {triangle.IsPrimary}");

// ------------------------------------------------------------------

IShape shape = new Circle(10);
Console.WriteLine($"{shape} area = {shape.Area}");

shape = CreateShape<Triangle>([3, 4, 5]);
Console.WriteLine($"{shape} area = {shape.Area}");

shape = CreateShape<Rectangle>([5, 10, 5, 10]);
Console.WriteLine($"{shape} area = {shape.Area}");

try
{
    Rectangle rectangle = CreateShape<Rectangle>([5, 10, 12, 10]);
    Console.WriteLine($"{rectangle} area = {rectangle.Area}");
}
catch (Exception exc)
{
    Console.WriteLine(exc.Message);
}

T CreateShape<T>(double[] lengths)
{
    List<Edge> edges = [];
    foreach (double length in lengths) edges.Add(new Edge(length));
    return (T)Activator.CreateInstance(typeof(T), edges)!;
}