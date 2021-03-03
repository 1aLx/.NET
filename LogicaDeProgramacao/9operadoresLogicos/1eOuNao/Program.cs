using System;

namespace _1eOuNao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma variável usando um operador lógico. (&& = E)
            bool c1 = 2 > 3 && 4 != 5; //false.

            //Essa condição será FALSA pois 2 NÃO É MAIOR QUE 3 (false) E 4 É DIFERENTE DE 5. (true). Então && = false + true = false.
            System.Console.WriteLine(c1); 

            //Criando uma variável usando um operador lógico. (|| = OU)
            bool c2 = 2 > 3 || 4 != 5; //true.

            //Essa condição será VERDADEIRA apesar de que 2 NÃO É MAIOR DO QUE 3 porém 4 É DIFERENTE DE 5. Basta somente 1 ser verdadeiro pois se trata de um OU.
            System.Console.WriteLine(c2);

            //Criando uma variável usando um operador lógico. (! = NÃO)
            bool c3 = !(2 > 3) && 4 != 5; //true.

            //Neste caso temos um NÃO, porém, na lógica 2 é maior do que 3 mas temos o ! que irá negar isso então se tornará FALSO.
            //Então somente neste caso 2 É MAIOR DO QUE 3 E 4 É DIFERENTE DE 5, ou seja, esta expressão será verdadeira.
            System.Console.WriteLine(c3);

            //Criando uma precedencia (&&(E) será resolvido primeiro e depois OU(||)).
            bool c4 = 10 < 5; //false.

            //Criando uma variavel com outras variaveis com precedentes.
            bool c5 = c2 || c3 && c4; //1º resolve && depois resolve ||.

            //C3 é true e c4 é false = FALSE | c2 é true => TRUE || FALSE = TRUE 
            System.Console.WriteLine(c5); //true.
        }
    }
}
