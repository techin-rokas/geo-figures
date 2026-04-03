namespace GeoFigures
{

  public class Circle
  {
    public double Radius { get; set; }


    public Circle(double radius)
    {
      Radius = radius;
    }

    public override string ToString()
    {
      return $"Circle radius is: {Math.Round(Radius, 2)}, Perimeter is: {Math.Round(Perimeter, 2)}, Area is: {Math.Round(Area, 2)}";
    }

    public double Perimeter => 2 * Math.PI * Radius;
    public double Area => Math.PI * Math.Pow(Radius, 2);
  }
}
