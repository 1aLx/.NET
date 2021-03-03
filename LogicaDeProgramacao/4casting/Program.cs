using System;

namespace _4casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implicita entre tipos pois 4 bytes cabem em 8 bytes
            float x = 4.5f; //4 bytes
            double y = x; //8 bytes

            System.Console.WriteLine(y);

            //Processo inverso
            double a;
            float b;

            a = 5.1;
            b = (float) a;

            System.Console.WriteLine(b);

            //Outro exemplo com variaveis diferentes
            double c;
            int d;

            c = 5.1;
            d = (int) c;

            System.Console.WriteLine(d); //Perca de informação. (De 5,1 para 5)

            //Exemplo com calculo de variaveis de ipo int para um resultado double
            int n1 = 5;
            int n2 = 2;

            double resultado = n1 / n2;

            System.Console.WriteLine(resultado);

            /*Tanto o valor n1 e o valor n2 são inteiros então, mesmo que a variavel resultado tenha declarado como
            double, o resultado será inteiro (2). Neste caso, para ter o valor real em decimal deveria fazer um CASTING.
            Ex: double resultado = (double) n1 / n2; */
            
            resultado = (double) n1 / n2;

            System.Console.WriteLine(resultado);
        }
    }
}
