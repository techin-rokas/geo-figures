namespace GeoFigures
{

  class Program
  {
    static void Main()
    {
      Circle circle = new Circle(5.524623462);
      Console.WriteLine(circle);

      Triangle triangle = new Triangle(10.243513, 5.23462346);
      Console.WriteLine(triangle);

      Rectangle rectangle = null;
      try
      {
        rectangle = new Rectangle(10.23462346, 25.23462346);
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
      }
      Console.WriteLine(rectangle);

      // Console.WriteLine(rectangle.Perimeter);

    }
  }
}
