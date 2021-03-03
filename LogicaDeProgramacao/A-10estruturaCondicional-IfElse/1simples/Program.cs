using System;

namespace _1simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            
            //Variével verdadeira. Imprime para o usuário. (true)
            if (x > 5)
            {
                System.Console.WriteLine("Bom dia!");
            }
            
            //Quando a condição é falsa ela não imprime essa condição.
            if (x < 5)
            {
                System.Console.WriteLine("Boa tarde!");
            }
           
            //Outra variavel verdadeira, então, imprime para o usuário. (true)
            if (x >= 5)
            {
                System.Console.WriteLine("Boa noite!");
            }
        }
    }
}
