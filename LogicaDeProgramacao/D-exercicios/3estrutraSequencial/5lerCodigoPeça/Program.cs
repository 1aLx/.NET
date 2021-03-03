using System;
using System.Globalization;

namespace _5lerCodigoPeça
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário
            de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada
            peça 2. Calcule e mostre o valor a ser pago. */

            //Criando um vetor para ler as variáveis. (int / int / double)
            System.Console.Write("Informe o código da peça 1 o número de peças e o seu preço (mesma linha): ");
            string [] peca1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(peca1[0]);
            int numeroPecas1 = int.Parse(peca1[1]);
            double preco1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            //Criando o segundo vetor para a entrada de dados.
            System.Console.Write("Informe o código da peça 2 o número de peças e o seu preço (mesma linha): ");
            string [] peca2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(peca2[0]);
            int numeroPecas2 = int.Parse(peca2[1]);
            double preco2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            //Calculo final dos produtos.
            double precoFinal = (double) (numeroPecas1 * preco1) + (numeroPecas2 * preco2);

            //Saida de dados.
            System.Console.WriteLine($"VALOR A PAGAR: R${precoFinal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
