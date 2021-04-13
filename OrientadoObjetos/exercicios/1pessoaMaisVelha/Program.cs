using System;

namespace _1pessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os dados de duas pessoas, depois
            mostrar o nome da pessoa mais velha. */

            //Criando a classe pessoa.
            //Criando as duas variáveis para informar a pessoa 1 e a pessoa 2.
            Pessoa x, y;
            x = new Pessoa(); //1ª pessoa.
            y = new Pessoa(); //2ª pessoa.

            Console.WriteLine("Dados da 1ª pessoa: ");

            Console.Write("Nome: "); //Buscando o atributo nome na classe e juntando a X (1ª pessoa)
            x.Nome = Console.ReadLine();

            Console.Write("Idade: "); //Buscando o atributo idade na classe e juntando a X (1ª pessoa)
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da 2ª pessoa: ");
            Console.Write("Nome: "); //Buscando o atributo nome na classe e juntando a Y (2ª pessoa)
            y.Nome = Console.ReadLine();

            System.Console.Write("Idade: "); //Buscando o atributo nome na classe e juntando a X (2ª pessoa)
            y.Idade = int.Parse(Console.ReadLine());

            //Informando quem é a pessoa mais velha.
            if (x.Idade > y.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {x.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {y.Nome}");
            }
        }
    }
}
