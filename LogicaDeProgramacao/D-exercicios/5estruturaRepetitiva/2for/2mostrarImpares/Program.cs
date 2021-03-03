using System;

namespace _2mostrarImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia um valor inteiro X (1 <= X <= 1000). Em seguida, mostre os ímpares de 
            1 até X, um valor por linha, inclusive o X, se for o caso. */

            System.Console.Write("Informe um valor para X: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X ; i++) //i = 1 => Impares de 1
            {
                if (i % 2 != 0) // valores diferentes de resto 0 são ímpares = 1, 3, 5, 7... 
                {
                    System.Console.WriteLine(i); //Apresentando os valores do resto de cada divisão.
                }
            }
        }
    }
}
