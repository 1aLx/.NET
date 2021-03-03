using System;

namespace _1numeroNegativoPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            System.Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0) //Menor que 0 é negativo.
            {
                System.Console.WriteLine("NEGATIVO. ");
            }
            else //Se não, ele é NÃO NEGATIVO.
            {
                System.Console.WriteLine("NÃO NEGATIVO.");
            }
        }
    }
}
