namespace GeoFigures
{

  class Program
  {
    static void Main()
    {
      Circle circle = new Circle(5.5);
      Console.WriteLine(circle);

      Triangle triangle = new Triangle(10, 5);
      Console.WriteLine(triangle);

      Rectangle rectangle = new Rectangle(-15, 25);
      Console.WriteLine(rectangle);
    }
  }
}
