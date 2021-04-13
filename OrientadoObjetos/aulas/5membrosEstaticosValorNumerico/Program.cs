using System;
using System.Globalization;

namespace _5membrosEstaticosValorNumerico
{
    class Program
    {

        static double Pi = 3.14;

        static void Main(string[] args)
        {
            /*Fazer um programa para ler um valor numérico qualquer. Depois mostrar
             quanto seria o valor de uma circunferencia e do volume de uma esfera
            para um raio daquele valor. Informar também o valor de PI com duas 
            casas decimais. */

            Console.Write("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Circunferencia(raio);           
            double volume = Volume(raio);

            Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");

        }
        
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume (double r)
        {
            return 4 * Pi * Math.Pow(r, 3) / 3;
        }
    }
}
