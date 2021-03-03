using System;
using System.Globalization;

namespace _4casoDeTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos
            de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.*/

            System.Console.Write("Informe um valor para N: "); //Usuário informa quantas vezes quer que faça a média ponderada.
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) //Condição feita para usuário repetir quantas vezes foi informada na variavel N.
            {
                System.Console.Write($"Informe os números: ");
                string [] linha = Console.ReadLine().Split(' '); //Vetor criado para o usuário informar os valores da média ponderada
                double a = double.Parse(linha[0], CultureInfo.InvariantCulture);
                double b = double.Parse(linha[1], CultureInfo.InvariantCulture);
                double c = double.Parse(linha[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / (2.0 + 3.0 + 5.0); //Calculo para fazer a media ponderada

                //Apresentando os valores de cada linha para o usuário.
                System.Console.WriteLine($"Média ponderada = {media.ToString("F1", CultureInfo.InvariantCulture)}");

            }
        }
    }
}
