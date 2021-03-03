using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando variáveis
            //Overflow: Quando um cálculo extrapola um limite de uma variável expecífica.

            SByte x = 127; //-128 a 127. Caso incremente +1 em 255 o valor retorna ao inicio (-128).
            System.Console.WriteLine(x); //Sbyte = numero que possua sinal, ou seja, números positivos e negativos.

            byte n1 = 255; //de 0 a 255. Caso incremente +1 em 255 o valor retorna ao inicio (0).
            System.Console.WriteLine(n1); //byte = exemplo de um numero que não tem sinal, ou seja, número não negativo.
            
            int n2 = 2147483647; //-2.147.483.647 à 2.147.483.647
            System.Console.WriteLine(n2); 

            long n3 = 2147483648L; //Utilizamos o long quando queremos definir um numero maior do que a variavel int armazena.
            System.Console.WriteLine(n3); //A letra L é para informar um numero longo

            bool completo = false; //Variável feita para guardar um valor true ou false
            System.Console.WriteLine(completo);

            char genero = 'F'; //Variável criada para guardar um caractere unicode.(https://unicode-table.com/pt/)
            System.Console.WriteLine(genero);

            char letra = '\u0041'; //Variavel exemplo com um definição UNICODE. (Letra A)
            System.Console.WriteLine(letra);

            float n4 = 4.5f; //Variável criada para números com ponto flutuante ou decimais.
            System.Console.WriteLine(n4); //A letra F serve para indicar que estou trabalhando com uma variavel float.

            double n5 = 4.5; //Variável criada para números com ponto flutuante ou decimais.
            System.Console.WriteLine(n5);

            string frase = "Olá, mundo."; //Variável criada para denominar um texto ou frase.
            System.Console.WriteLine(frase);
            
            object obj1 = "Alexandre"; //Variável de tipo genérica.
            System.Console.WriteLine(obj1);

            object obj2 = 4.5f;
            System.Console.WriteLine(obj2);

            //Valores máximos:
            System.Console.WriteLine("-----------------------");

            int a = int.MinValue; //valor mínimo
            int b = int.MaxValue; //valor máximo
            SByte c = SByte.MinValue;
            decimal d = decimal.MaxValue;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
        }
    }
}
