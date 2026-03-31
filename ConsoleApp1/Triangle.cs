namespace GeoFigures
{

  public class Triangle
  {
    public double TriangleBase { get; set; }
    public double Height { get; set; }

    public Triangle(double triangleBase, double height)
    {
      TriangleBase = triangleBase;
      Height = height;
    }

    public override string ToString()
    {
      return $"Triangle base is: {TriangleBase}, height is: {Height}";
    }
  }
}
