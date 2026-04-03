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
      return $"Circle radius is: {Math.Round(Radius, 2)}";
    }
  }
}
