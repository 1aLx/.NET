using System;

namespace _3operadoresAtribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            //Incrementando um valor sem precisar criar outra variavel de soma;

            int a = 10; // a = 10
            System.Console.WriteLine(a);

            a += 2; // a = 10 + 2 | a = 12
            System.Console.WriteLine(a);

            a *= 3; // a = 12 x 3 | a = 36
            System.Console.WriteLine(a);

            
            //Também funciona com string.
            string s = "Alexandre";
            System.Console.WriteLine(s);

            s += " Abreu"; //Adiciona o texto logo a frente da variavel anterior.
            System.Console.WriteLine(s);

            //Operador aritmético / atribuição. (++)(--)

            int b = 10;
            b++; // b = b + 1.
            System.Console.WriteLine(b);

            b--; //b = b - 1;
            System.Console.WriteLine(b);



        }
    }
}
