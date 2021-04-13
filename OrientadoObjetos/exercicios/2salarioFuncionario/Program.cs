using System;
using System.Globalization;

namespace _2salarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários. */

            //Criando a classe Funcionario.
            Funcionario x, y;

            //Criando as variaveis pessoas x e y (1ª pessoa e 2ª pessoa).
            x = new Funcionario();
            y = new Funcionario();

            //1º funcionário / pessoas.

            Console.WriteLine("Dados do 1º funcionário: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();

            Console.Write("Salário: R$");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //2ª funcionário / pessoa.

            Console.WriteLine("Dados do 2º funcionário: ");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();

            Console.Write("Salário: R$");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Calculando a média dos dois salários.
            double mediaSalario = (x.Salario + y.Salario) / 2.0;

            Console.WriteLine($"Salário médio = R${mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
