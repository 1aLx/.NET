using System;
using System.Globalization;

namespace _7entradaDeDadosPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            -Ler um número inteiro
            -Ler um caractere
            -Ler um número double
            -Ler um nome (única palavra), sexo(caractere F ou M), idade (inteiro) e a altura (double) na mesma linha,
            armazenando-os em quatro variáveis com os devidos tipos.
            */
            
            //Ler um número inteiro.
            System.Console.Write("Digite sua idade: ");
            int n1 = int.Parse(Console.ReadLine());

            //Ler um caractere.
            System.Console.Write("Digite seu sexo em 1 caractere: "); 
            char ch = char.Parse(Console.ReadLine());

            //Ler um número double.
            System.Console.Write("Agora digite sua altura: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saída de dados.
            System.Console.WriteLine($"Idade: {n1} | Sexo: {ch} | Altura: {n2}m");

            //Armazenando quatro variaveis em um vetor
            System.Console.Write("Digite a seu nome, sexo, idade e sua altura na ordem refereten a essa frase: ");
            string [] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char sex = char.Parse(vet[1]); //Convertando para char pois meu vetor é um string.
            int age = int.Parse(vet[2]); //Seguindo o mesmo raciocínio do exemplo acima porém de variavel int.
            double height = double.Parse(vet[3], CultureInfo.InvariantCulture); //Convertendo para double.

            System.Console.WriteLine($"Nome: {name} / Sexo: {sex} / Idade: {age} / Altura: {height.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
