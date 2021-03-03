using System;

namespace _6entradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine(); //Usuário digita uma frase para armazena-la em uma entrada de dados.//

            System.Console.WriteLine($"Você digitou: {frase}");

            //---------------------------------------------------------------------------------------------------//

            System.Console.Write("Digite uma cor: ");
            string x = Console.ReadLine();

            System.Console.Write("Agora digite uma 2ª cor: ");
            string y = Console.ReadLine();

            System.Console.Write("Agora digite uma ultima cor: ");
            string z = Console.ReadLine();

            System.Console.WriteLine($"Você digitou 3 cores: {x}, {y} e {z}");

            //---------------------------------------------------------------------------------------------------//

            //Aprendendo o comando split (quase um vetor) Digitando 3 variaveis ou mais e armazenando em 1 Console.ReadLine()

            System.Console.Write("Digite 3 cores novas: ");

            string [] v = Console.ReadLine().Split(' '); //pode ser uma virgula ou hífen.
            string a = v[0];
            string b = v[1];
            string c = v[2];

            //Armazenando 3 palavras em um vetor.

            System.Console.Write($"Você digitou 3 cores novas: {a} {b} {c}");
        }
    }
}
