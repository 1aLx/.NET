using System;
using System.Globalization;

namespace _3exEncadeamento
{
    class Program
    {
        static void Main(string[] args)
        {
           //Criando um programa onde irá oferecer um desconto ao cliente quando for faze ruma compra acima de R$100.00

           System.Console.Write("Qual foi o valor total da compra? ");
           double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = 0.0; //Iniciando o valor do desconto em 0%.

            if (preco > 100.00 && preco <= 149.99)
            {
                desconto = preco * 0.1;

                System.Console.WriteLine($"Seu desconto será de: R${desconto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (preco > 149.99 && preco <= 300.00)
            {
                desconto = preco * 0.2;

                System.Console.WriteLine($"Seu desconto será de: R${desconto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                System.Console.WriteLine("Obrigado por comprar com a gente.");
            }

        }
    }
}
