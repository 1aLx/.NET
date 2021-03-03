using System;

namespace _1exSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler três números e informar o maior deles.

            System.Console.WriteLine("Informe os 3 números: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c) //Caso o numero A seja maior que os outros.
            {
                System.Console.WriteLine($"Maior = {a}");
            }
            else if (b > a && b > c) //Caso B seja maior que A e C.
            {
                System.Console.WriteLine($"Maior = {b}");
            }
            else //Caso o C seja maior que A e B.
            {
                System.Console.WriteLine($"Maior = {c}");
            }
        }
    }
}
