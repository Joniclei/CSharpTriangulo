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

      double p = ((x.A + x.B + x.C)/2.0);
      double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

      p = ((y.A + y.B + y.C)/2.0);
      double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

      Console.WriteLine($" Area de x {areaX}");
      Console.WriteLine($" Area de y {areaY}");

      double area = areaX > areaY ? areaX : areaY;

      Console.WriteLine(area);
    }
  }
}
