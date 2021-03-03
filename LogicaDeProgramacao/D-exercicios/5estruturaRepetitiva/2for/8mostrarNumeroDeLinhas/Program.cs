using System;

namespace _8mostrarNumeroDeLinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            exemplo.*/
            
            //Lendo um número inteiro de N linhas.
            System.Console.Write("Informe o número de linhas: ");
            
            //Exemplo iniciado com 5
            int n = int.Parse(Console.ReadLine());

            //Criando a estrutura começando com i = 1 para indicar a primeira linha e para fazer os calculos.
            for (int i = 1; i <= n; i++)
            {
                // -> = proxima linha.

                int primeiro = i; //1 -> 2 -> 3 -> 4 -> 5
                int segundo = i * i; // 1*1= 1 -> 2*2 = 4 -> 3*3 = 9 -> 4*4 = 16 -> 5*5 = 25
                int terceiro = i * i * i; // 1*1*1= 1 -> 2*2*2 = 8 -> 3*3*3 = 27 -> 4*4*4 = 64 -> 5*5*5 = 125

                //1 1 1
                //2 4 8 
                //3 9 27
                //4 16 64
                //5 25 125

                System.Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }

            // i = 1, i = 2, i = 3, i = 4, i=5, i!=6, finaliza.

        }
    }
}
