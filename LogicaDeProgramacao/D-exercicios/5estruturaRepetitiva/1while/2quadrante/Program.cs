using System;

namespace _2codigoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). */

            //O Sentido do quadrante é anti-horário.
            
            Console.Write("Informe o eixo X é Y: "); //Usuário informa os valores x e y.
            string [] values = Console.ReadLine().Split(' '); //Vetor para armazenar os valores X = 0,0 e Y = 0,1
            int x = int.Parse(values[0]); // 0,0
            int y = int.Parse(values[1]); // 0,1

            //Enquanto os valores do eixo X e de Y forem diferentes de 0 a condição será processada.
            while (x != 0 && y != 0)
	        {
                if (x > 0 && y > 0) //Caso os valores X e Y sejam positivos.
	            {
                    Console.WriteLine("Primeiro quadrante.");
	            }
                else if (x < 0 && y > 0) //Caso o valor de X seja negativo e o valor de Y seja positivo.
	            {
                    Console.WriteLine("Segundo quandrante.");
	            }
                else if (x < 0 && y < 0) //Caso as duas variáveis sejam negativas.
	            {
                    Console.WriteLine("Terceiro quadrante.");
	            }
                else //Enfim, o Eixo onde o X é positivo e Y é negativo.
                {
                    Console.WriteLine("Quarto quadrante.");
                }
                
                Console.Write("Informe o eixo X é Y: ");
                values = Console.ReadLine().Split(' ');
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);

	        }
            
            System.Console.WriteLine("NULA.");

        }
    }
}
