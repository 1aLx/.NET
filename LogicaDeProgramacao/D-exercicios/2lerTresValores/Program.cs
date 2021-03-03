using System;
using System.Globalization;

namespace _1lerTresValores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para executar a seguinte interação com o usuário,
               lendo os valores destacados em vermelho, e depois apresenta-los na
               tela. 
            */

            //Nome do usuário: (string)
            System.Console.Write("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            //Número de quartos: (int)
            System.Console.Write("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            //preço do produto: (double)
            System.Console.Write("Entre com o preço de um produto: R$");        
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Apresentando o resultado ao usuário: (Saída de dados)
            System.Console.WriteLine($"Nome: {nome} | Quartos: {quartos} | Preço do produto: R${produto.ToString("F2", CultureInfo.InvariantCulture)}");
            
            //Somente um espaçamento.
            System.Console.WriteLine();

            //Criando um vetor para o usuário digitar na mesma linha do terminal: (string [] vet)
            System.Console.WriteLine("Digite seu último nome, idade e altura (mesma linha): ");
            
            string [] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0]; //Não precisa converter pois o vetor ja se trata de uma string
            int idade = int.Parse(vet[1]); //Convertendo para int
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture); //Convertendo para double

            //Apresentando os dados do vetor: (Saída de dados do vetor)
            System.Console.WriteLine($"Último nome: {nome1} | Idade: {idade} | Altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
