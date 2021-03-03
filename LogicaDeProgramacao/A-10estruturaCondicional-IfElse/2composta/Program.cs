using System;

namespace _2composta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Entre com um número inteiro: "10" = PAR!
            Entre com um número ímpar: "15" = ÍMPAR!*/

            //Criando uma variavel para o usuário informar um número inteiro.
            System.Console.Write("Informe um número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            //Números pares são divisíveis por 2 onde o resto sempre será 0.
            if ((numero1 % 2) == 0) //Se tal coisa for...
            {
                System.Console.WriteLine("Par!");
            }
            else //Se não, será isso...
            {
                System.Console.WriteLine("Ímpar");
            }

            //Agora pedindo para o usuário entrar com um número inteiro ímpar.
            System.Console.Write("Entre com um número ímpar: ");
            int numero2 = int.Parse(Console.ReadLine());

            if ((numero2 % 2) == 1) //Se tal coisa for..
            {
                System.Console.WriteLine("Ímpar!");
            }
            else //Se não, será isso...
            {
                System.Console.WriteLine("Par!");
            }
        }
    }
}
