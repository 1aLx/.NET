using System;

namespace _1boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma expressão de condição (bool)
            int a = 10;
            
            //Essa variável irá verificar se A é menor que 10.
            bool condition1 = a < 10;
            
            //Neste caso a será igual à 10, então, na saída de dados aprensentará falso como resultado.
            System.Console.WriteLine(condition1);

            //Criando outra variável com o valor A menor do que 20.
            bool condition2 = a < 20;

            //Neste caso 20 é maior do que A então a condição será verdadeira. 
            System.Console.WriteLine(condition2);

            //Criando outra variável com a condição A maior do que 10.
            bool condition3 = a > 10;

            //Neste caso, A não é nem maior e nem menor do que 10. (Falso).
            System.Console.WriteLine(condition3);

            //Criando outra variável com a condição A maior do que 5.
            bool condition4 = a > 5;

            //Neste caso a condição será verdadeira pois, A é maior do que 5.
            System.Console.WriteLine(condition4);

            //Criando uma variavel com a condição A menor ou igual à 10.
            bool condition5 = a <= 10;

            //Será verdadeira pois A é menor OU IGUAL À 10.
            System.Console.WriteLine(condition5);

            //Criando uma variável com a condição recebendo A maior ou igual à 10.
            bool condition6 = a >= 10;

            //Também será verdadeira pois A é maior OU IGUAL À 10.
            System.Console.WriteLine(condition6);

            //Criando uma variavel com a condição de comparação.
            bool condition7 = a == 10;

            //Também será verdadeira pois A É COMPARADO(IGUAL) Á 10.
            System.Console.WriteLine(condition7);

            //Criando uma variável com uma condção de diferença.
            bool condition8 = a != 10;

            //Neste caso será FALSO pois A não É DIFERENTE DE 10.
            System.Console.WriteLine(condition8);
        }
    }
}
