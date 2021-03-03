using System;
using System.Globalization;

namespace _5mostrarDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a 
            divisão do primeiro pelo segundo. Se o denominador for igual a zero, mostrar a mensagem
            "divisão impossivel". */

            System.Console.Write("Informe quantas vezes quer fazer essa divisão: ");
            int n = int.Parse(Console.ReadLine()); //Quantas vezes o usuário quer fazer esta divisão.

            //Condição para o usuário calcular quantas vezes o calculo será feito.
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Informe 2 valores para fazer a divisão: ");
                string [] valores = Console.ReadLine().Split(' ');
                int a = int.Parse(valores[0]); 
                int b = int.Parse(valores[1]); //Denominador.

                //Caso o denominador for zero a divisão será impossível.
                if (b == 0)
                {
                    System.Console.WriteLine("Divisão impossível.");
                }
                //Se não, a divisão será feita normalmente.
                else  
                {
                    double divisao = (double) a / b;
                    System.Console.WriteLine($"Resultado = {divisao.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
