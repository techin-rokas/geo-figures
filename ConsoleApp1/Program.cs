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

      Rectangle rectangle = null;
      try
      {
        rectangle = new Rectangle(-10, 25);
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
      }
      Console.WriteLine(rectangle);
    }
  }
}
