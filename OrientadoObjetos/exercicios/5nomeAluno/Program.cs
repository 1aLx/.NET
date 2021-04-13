using System;
using System.Globalization;

namespace _5nomeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
            este problema. */

            Aluno x = new Aluno();
            
            Console.Write("Informe o nome do aluno: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            
            Console.Write($"1º: ");
            x.Primeiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"2º: ");
            x.Segundo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"3º: ");
            x.Terceiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"Nota final: {x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (x.Aprovado())
            {
                Console.WriteLine("Aprovado.");
            }
            else
            {
                Console.WriteLine($"Reprovado! Faltaram {x.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} pontos.");
            }
        }
    }
}
