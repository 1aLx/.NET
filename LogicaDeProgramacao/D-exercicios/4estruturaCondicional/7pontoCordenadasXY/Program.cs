using System;
using System.Globalization;

namespace _7pontoCordenadasXY
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 2 valores com uma casa decimal (x e y), que devem representar as 
            coordenadas de um ponto em um plano. A seguir, determine qual o quadrante 
            ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na 
            origem (x = y = 0). Se o ponto estiver na origem, escreva a mensagem 
            "Origem". Se o ponto estiver sobre um dos eixos escreva "Eixo X" ou "Eixo Y",
            conforme for a situação.*/

            System.Console.Write("Informe o valor de X e o valor de Y: ");
            string [] values = Console.ReadLine().Split(' ');
            double x = double.Parse(values[0], CultureInfo.InvariantCulture);
            double y = double.Parse(values[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) // Ponto central
            {
                System.Console.WriteLine("Origem.");
            }
            else if (x > 0.0 && y > 0.0) //Maior que 0(0.1+) para x e y.
            {
                System.Console.WriteLine("Q1.");
            }
            else if (x < 0.0 && y > 0.0) //X sendo menor que 0(-0.1) e y(+0.1) -x +y 
            {
                System.Console.WriteLine("Q2.");
            }
            else if (x < 0.0 && y < 0.0) //Os dois eixos sendo menor que 0. Ex: x e y = -0.1
            {
                System.Console.WriteLine("Q3.");
            }
            else
            {
                System.Console.WriteLine("Q4.");
            }
        }
    }
}
