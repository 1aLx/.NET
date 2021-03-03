using System;
using System.Globalization;

namespace _2raioDeUmCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da area
            deste círculo com quatro casas decimais.*/

            //Criando uma variável com o valor de pi. (https://docs.microsoft.com/pt-br/dotnet/api/system.math.pi?view=net-5.0)
            double pi = 3.1415926535897931;
            
            //Usuário informa o valor do raio.
            System.Console.Write("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criando uma variavel para calcular a área da circunfrencia.
            double area = pi * Math.Pow(raio, 2);

            //Apresentando o valor da área ao usuário:
            System.Console.Write($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
