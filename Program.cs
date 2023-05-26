using System;
using System.Globalization;

namespace Triangulo
{
  class Program
  {
    static void Main(string[] args)
    {

      Triang x,y;

      x = new Triang();
      y = new Triang();

      Console.WriteLine("Entre com as medidas do triangulo X:");

      x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
      x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
      x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

      Console.WriteLine("Entre com as medidas do triangulo Y:");

      y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
      y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
      y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

      double areaX = x.Area();
      double areaY = y.Area();


      Console.WriteLine($" Area de x {areaX}");
      Console.WriteLine($" Area de y {areaY}");

      double area = areaX > areaY ? areaX : areaY;

      Console.WriteLine(area);
    }
  }
}
