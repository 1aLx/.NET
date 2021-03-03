using System;

namespace _3valoresXIntervalo1020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). */

            System.Console.Write("Informe um valor máximo para N: "); //N será o numero maximo de repetições.
            int n = int.Parse(Console.ReadLine());

            //Essas variaveis foram criadas para informar a quantidade de vezes que foram repetidas dentro e fora de cada intervalow
            int contIN = 0; //dentro do intervalo 10 ~ 20
            int contOUT = 0; //Fora do intervalo 10 ~ 20

            for (int i = 0; i < n; i++)  
            {
                System.Console.Write("Agora informe um valor para X: "); //Onde o usuário informa os números para fazer a contagem..
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20) //Caso o número seja maior que 10 e menor que 20 será armazenado em contIN.
                {
                    contIN = contIN +1;
                }
                else //Caso ele não seja do inetrvalo, armazenara em contOUT.
                {
                    contOUT = contOUT +1;
                }
            }
                
            //Apresentando os números.
            System.Console.WriteLine($"{contIN} in");
            System.Console.WriteLine($"{contOUT} out");
            
        }
    }
}
