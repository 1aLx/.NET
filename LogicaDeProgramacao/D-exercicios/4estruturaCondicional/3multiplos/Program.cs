using System;

namespace _3multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Leia 2 valores INTEIROS (A e B). Após, o programa deve mostrar uma mensagem: "São múltiplos" ou 
           "Não são multiplos", indicando se os valores lidos são mulriplos entre si. Atenção: os números
           devem poder ser digitados em ordem crescente ou decrescente.*/

           System.Console.Write("Informe os dois números para saber se são múltiplos ou não: ");
           string [] numeros = Console.ReadLine().Split(' ');
           int A = int.Parse(numeros[0]);
           int B = int.Parse(numeros[1]);

           if (A % B == 0 || B % A == 0) //OU
           {
               System.Console.WriteLine("São múltiplos.");
           }
           else
           {
               System.Console.WriteLine("Não são múltiplos.");
           }

        }
    }
}
