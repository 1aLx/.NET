using System;

namespace _1informarValoresESomar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Digitar um número N e depois N valores inteiros. Mostrar a soma dos N valores
            digitados. */

            System.Console.Write("Quantos números você irá digitar: ");
            int N = int.Parse(Console.ReadLine()); //numero informado do exemplo: 3 

            int soma = 0;
            
            for (int i = 1; i <= N; i++) //Variavel i começando com 1 pois utilizarei a mesma variavel para demonstrar o primeiro valor
            {
                System.Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine()); //Armazenando os valores.
                
                soma = soma + valor; //Substituição da primeira variavel para fazer a soma das demais após o incremento e a condição.

            }

            System.Console.WriteLine($"Soma = {soma}"); //Resultado da soma total da soma.
        }
    }
}
