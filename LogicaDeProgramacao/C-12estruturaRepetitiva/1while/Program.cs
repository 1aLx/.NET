using System;
using System.Globalization;

namespace _1problemaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Digitar um número e mostrar sua raiz quadrada com três casas decimais,
            depois repetir o procedimento. Quando o usuário digitar um número negativo
            (podendo inclusive ser na primeira vez), mostrar uma mensagem "Número 
            negativo" e terminar o programa. */

            System.Console.Write("Informe um número: ");
            double numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numero >= 0.0)
            {
                //Chamando a função Sqrt e armazenando-a em uma variável.
                double raiz = Math.Sqrt(numero);
                //Apresentando o resultado.
                System.Console.WriteLine($"{raiz.ToString("F3", CultureInfo.InvariantCulture)}");
                //Como é uma estrutura repetitiva ela irá retornar ao inicio. Então vamos criar a mesma pergunta do inicio.
                System.Console.Write("Informe outro número: ");
                //A condição, sempre que for verdadeira, sempre será repetitva.
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Variavel numero já declarada.
    
            }         

            //Agora neste caso, a condição da estrutura repetitiva é falsa (numero negativo).
            System.Console.WriteLine("Número negativo.");

        }
    }
}
