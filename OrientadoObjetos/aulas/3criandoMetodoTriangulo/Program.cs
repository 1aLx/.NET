using System;
using System.Globalization;

namespace _3criandoMetodoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um método (função) dentro da classe triangulo.

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Informe as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Informe as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Essa simples chamada vai fazer toda aquela função Area() dentro da classe.
            double areaX = x.Area();
            double areaY = y.Area();

            System.Console.WriteLine($"Area X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Area Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine($"Maior área: X");
            }
            else
            {
                Console.WriteLine($"Maior área: Y");
            }
        }
    }
}
