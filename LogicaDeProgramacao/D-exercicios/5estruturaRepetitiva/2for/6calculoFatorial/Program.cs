using System;

namespace _6calculoFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler um valor N. Calcular e escrever seu respectivo fatorial.
            Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. Lembrando
            que, por definição, fotarial de 0 é 1.*/

            //Fatorial =  número inteiro natural positivo.

            System.Console.Write("Informe um valor para N fatorial: ");
            int n = int.Parse(Console.ReadLine()); //Inciando com exemplo 4.

            //Fatorial de 0 será sempre 1.
            int fatorial = 1;
            // = 1
            // = 2
            // = 6
            // = 24
            
            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }
            
            System.Console.WriteLine($"Fatorial = {fatorial}");

        }
    }
}
//n = 4 || i = 1, i = 2, i = 3, i = 4, i != 5, finaliza a variavel.