using System;
using System.Globalization;

namespace _6membrosEstaticosValorNumericoPt2
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Fazer um programa para ler um valor numérico qualquer. Depois mostrar
             quanto seria o valor de uma circunferencia e do volume de uma esfera
            para um raio daquele valor. Informar também o valor de PI com duas 
            casas decimais. */

            //Por se tratarem de membros estaticos podemos colocar somente o nome da classe como parametro das variaveis.

            Console.Write("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
