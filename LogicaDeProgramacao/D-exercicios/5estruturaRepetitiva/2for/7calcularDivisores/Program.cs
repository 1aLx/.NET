using System;

namespace _7calcularDivisores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler um número N e calcular seus divisores.*/

            System.Console.Write("Informe um número para calcular seus divisores.");
            int n = int.Parse(Console.ReadLine()); //Exemplo informado = 6.
            // = 6.

            for (int i = 1; i <= n; i++)
            {
                //Para saber os divisores corretos o resto da divisão sempre será 0.
                //Caso o I seja divisivel pelo numero informado sempre for resto 0 ele será apresentado como denominador divisor.
                if (n % i == 0)
                {
                    System.Console.WriteLine($"Divisores: {i}");
                }                
            }

            //i = 1, cw > i = 1, i = 2, i = 3, i = 6, i != 7


        }
    }
}
