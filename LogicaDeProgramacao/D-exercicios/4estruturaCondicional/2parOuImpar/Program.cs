using System;

namespace _2parOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

           System.Console.Write("Informe um número inteiro: ");
           int numero = int.Parse(Console.ReadLine());

           if (numero % 2 == 0) //Todo numero par tem o resto 0.
           {
               System.Console.WriteLine("PAR.");
           }
           else
           {
               System.Console.WriteLine("IMPAR.");
           }
        }
    }
}
