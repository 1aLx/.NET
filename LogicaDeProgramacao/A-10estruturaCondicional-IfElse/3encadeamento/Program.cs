using System;

namespace _2demoRelogioComposta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimindo uma mensagem de bom dia, boa tarde ou boa noite dependendo do horário que o usuário informar.
            System.Console.Write("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                System.Console.WriteLine("Bom dia!");
            }
            else if (12 >= hora && hora < 18)
            {
                System.Console.WriteLine("Boa tarde!");
            }
            else
            {
                System.Console.WriteLine("Boa noite");
            }
        }
    }
}
