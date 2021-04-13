using System;
using System.Globalization;

namespace _1exemploTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler as medidas dos lados de dois riângulos X e Y (suponha
            medidas válidas). Em seguida, mostar o valor das areas dos dois triangulos e dizer
            qual dos dois triangulos possui maior area.
            A fórmula para calcular a área de um triangulo a partir das medidas de seus lados a,
            b, c e a seguinte (fórmula de Heron): */

            Console.WriteLine("Informe as medidas do triângulo X: ");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe as medidas do triângulo Y: ");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"Area X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

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
