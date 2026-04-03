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
      return $"Triangle Base is: {Math.Round(TriangleBase, 2)}, Height is: {Math.Round(Height, 2)}, Perimeter is: {Math.Round(GetPerimeter(), 2)}, Area is {Math.Round(GetArea, 2)}";
    }

    public double GetPerimeter()
    {
      double hypotenuse = Math.Sqrt(Math.Pow(TriangleBase, 2) + Math.Pow(Height, 2));
      return TriangleBase + Height + hypotenuse;
    }

    public double GetArea => TriangleBase * Height / 2;
  }
}
