using System;
using System.Globalization;

namespace _3retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os valores da largura e altura
            de um retângulo. Em seguida, mostrar na tela o valor de sua
            área, perímetro e diagonal. Usar uma classe como mostrado
            no diagrama UML. */

            //Criando a classe retângulo.
            Retangulo x = new Retangulo();

            //Dados de entrada.
            Console.WriteLine("Informe a largura e altura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Dados de saída.
            Console.WriteLine(x);
        }
    }
}
