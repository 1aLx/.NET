using System;
using System.Globalization;

namespace _2trianguloOrientadoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando variaveis para identificar os atributos dentro da classe Triangulo 
            Triangulo x, y;
            x = new Triangulo(); //Triangulo X.
            y = new Triangulo(); //Triangulo Y.

            //Usando os atributos como referencia para armazenar o que o usuário irá digitar (X).

            System.Console.WriteLine("Informe as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Usando os mesmos atributos da classe, porém, armazenando em uma variável diferente (Y).

            System.Console.WriteLine("Informe as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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
