using System;
using System.Globalization;

namespace _5quantidadeItemTabela
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que leia o código de um
            item e a quantidade deste item. A seguir, calcule
            o valor da conta a pagar. */

            System.Console.Write("Informe os código e a quantidade dos produtos: ");
            string [] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;

            if (codigo == 1) //Cachorro quente.
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) //X-salada.
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) //X-Bacon.
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) //Torrada simples.
            {
                total = quantidade * 2.0;                
            }
            else //Refrigerante.
            {
                total = quantidade * 1.5;
            }
            
            System.Console.Write($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
