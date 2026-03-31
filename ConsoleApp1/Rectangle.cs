namespace GeoFigures
{

  public class Rectangle
  {
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
      if (width <= 0)
      {
        Console.WriteLine("Width must be positive!");
        return;
      }
      if (height <= 0)
      {
        Console.WriteLine("Height must be positive!");
        return;
      }
      Width = width;
      Height = height;
    }
    public override string ToString()
    {
      return $"Rectangle width is: {Width}, height is: {Height}";
    }
  }
}
