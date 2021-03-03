using System;

namespace _1lerDoisValoresInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler dois valores inteiros, e depois mostrar na tela
            a soma desses números com uma mensagem explicativa.*/

            //Lendo o primeiro número para fazer a soma.
            System.Console.Write("Informe o 1º número: ");
            int numero1 = int.Parse(Console.ReadLine());

            //Lendo o segundo número para a soma.
            System.Console.Write("Informe o 2º número: ");
            int numero2 = int.Parse(Console.ReadLine());

            //Somando as duas variáveis.
            int soma = numero1 + numero2;

            //Resultado da soma.
            System.Console.WriteLine($"SOMA = {soma}");
        }
    }
}
