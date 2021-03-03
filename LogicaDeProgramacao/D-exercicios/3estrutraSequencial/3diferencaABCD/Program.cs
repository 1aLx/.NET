using System;

namespace _3diferencaABCD
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler 4 valores inteiros A, B, C e D. A seguir,
            calcule e mostre a diferença do produto de A e B pelo produto de C e D 
            segundo a fórmula: DIFERENÇA = (A * B - C * D). */

            //Criando as variáveis para amazenar os números.
            System.Console.Write("Informe um número para A: ");
            int A = int.Parse(Console.ReadLine());

            System.Console.Write("Informe um número para B: ");
            int B = int.Parse(Console.ReadLine());

            System.Console.Write("Informe um número para C: ");
            int C = int.Parse(Console.ReadLine());

            System.Console.Write("Informe um número para D: ");
            int D = int.Parse(Console.ReadLine());
            
            //criando uma variavel para calcular a diferença:
            int diferenca = A * B - C * D;

            //Apresentando o resultado final da diferença para o usuário: (Saída de dados)
            System.Console.WriteLine($"DIFERENCA = {diferenca}");

        }
    }
}
