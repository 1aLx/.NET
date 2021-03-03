using System;

namespace _5operadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regras da matemática do ensino fundamental.
            
            int n1 = 3 + 4 * 2; //11
            int n2 = (3 + 4) * 2; //14
            int n3 = 17 % 3; //2. Por que dois? Pois a % quer dizer o resto da divisão. Ex: 17 / 3 = 5 (15) => 17 - 15 = (2)
             
            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);

            double n4 = 10.0 / 8.0; //Sempre que o resultado de uma expressão for em numeros decimais, declarar o numero com ponto flutuante como na variavel (10.0, 8.0)
            System.Console.WriteLine(n4);

            //Exemplo com equação de 2° grau (Bhaskara). -B + (Math.Sqrt(b² - 4 * a * c)) / 2 * a

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; //Math.Pow é uma função matemática para indicar poténcia (variavel, 2.0)

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            System.Console.WriteLine($"Delta = {delta}");
            System.Console.WriteLine($"X1 = {x1}");
            System.Console.WriteLine($"X2 = {x2}");
        }
    }
}
