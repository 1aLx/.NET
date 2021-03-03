using System;

namespace _2exemploDeFuncao
{
    class Program
    {
        static void Main(string[] args) //entry point
        {
            //Criando uma função para mostrar qual é o maior
            
            System.Console.WriteLine("Informe os 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3); //Criando uma função recebendo os valores que o usuario digitar

            System.Console.WriteLine($"Maior = {resultado}"); //Resultado da função Maior().

        }

        static int Maior(int a, int b, int c) //criando a função
        {
            int m; //variavel para armazenar o maior.

            if (a > b && a > c) //Testando se A é maior que B e C.
            {
                m = a;
            
            }
            else if (b > c) //Teste se B é maior do que C
            {
                m = b;
            }
            else //Se C é maior do que A ou B.
            {
                m = c;
            }

            return m; //Return vai mandar o resultado para o double resultado dentro da função entry point (static void Main(string[] args)).
        }
    }
}
