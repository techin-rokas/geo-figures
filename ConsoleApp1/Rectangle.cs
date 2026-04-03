namespace GeoFigures
{

  public class Rectangle
  {
    private double _width;
    private double _height;

    public double Width
    {
      get { return _width; }
      set
      {
        if (value <= 0)
          throw new ArgumentException("Width must be positive");
        _width = value;
      }
    }
    public double Height
    {
      get { return _height; }
      set
      {
        if (value <= 0)
          throw new ArgumentException("Height must be positive");
        _height = value;
      }
    }

    public Rectangle(double width, double height)
    {
      Width = width;
      Height = height;
    }
    public override string ToString()
    {
      return $"Rectangle Width is: {Math.Round(Width, 2)}, Height is: {Math.Round(Height, 2)}, Perimeter is: {Math.Round(GetPerimeter, 2)}, Area is: {Math.Round(GetArea, 2)}";
    }

    public double GetPerimeter => 2 * (Width + Height);
    public double GetArea => Width * Height;
  }
}
