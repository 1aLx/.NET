using System;
using System.Globalization;

namespace _6areaTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B. */
            
            //Usuário digita os lados do triângulo. (Entrada de dados)
            System.Console.Write("Informe os 3 valores (mesma linha): ");
            string [] lado = Console.ReadLine().Split(' ');
            double ladoA = double.Parse(lado[0], CultureInfo.InvariantCulture);
            double ladoB = double.Parse(lado[1], CultureInfo.InvariantCulture);
            double ladoC = double.Parse(lado[2], CultureInfo.InvariantCulture);

            //Calculo para especificar cada triângulo.
            double trianguloRetangulo = (ladoA * ladoC) / 2;
            double circuloRaio = Math.PI * Math.Pow(ladoC, 2);
            double trapezio = (ladoA + ladoB) * ladoC / 2;
            double quadrado = Math.Pow(ladoB, 2);
            double areaRetangulo = ladoA * ladoB;

            //Apresentando os resultados para o usuário. (Saída de dados)
            System.Console.WriteLine($"TRIANGULO: {trianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"CIRCULO: {circuloRaio.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
