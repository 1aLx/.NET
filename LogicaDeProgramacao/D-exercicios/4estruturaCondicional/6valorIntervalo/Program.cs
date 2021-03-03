using System;
using System.Globalization;

namespace _6valorIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Você deve fazer um programa que leia um valor qualquer e apresente 
            uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50],
            (50,75], (75,100]) este valor se encontra. Obviamente se o valor não 
            estiver em nenhum destes intervalos, deverá ser impressa a mensagem 
            “Fora de intervalo”.*/

            System.Console.Write("Informe um valor com duas casas decimais: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero > 0.00 && numero <= 25.00)
            {
                System.Console.WriteLine("Intervalo [0.00, 25.00]");
            }
            else if (numero > 25.00 && numero <= 50.00)
            {
                System.Console.WriteLine("Intervalo [25.00, 50.00]");
            }
            else if (numero > 50.00 && numero <= 75.00) 
            {
                System.Console.WriteLine("Intervalo [50.00, 75.00]");
            }
            else if (numero > 75.00 && numero <= 100.00)
            {
                System.Console.WriteLine("Intervalo [75.00, 100.00]");
            }
            else
            {
                System.Console.WriteLine("Fora do intervalo.");
            }
        }
    }
}
