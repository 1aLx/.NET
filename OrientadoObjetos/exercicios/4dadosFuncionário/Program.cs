using System;
using System.Globalization;

namespace _4dadosFuncionário
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os dados de um funcionário (nome, salário bruto
            e imposto). Em seguida, mostrar os dados do funcionário (nome e salário 
            líquido). Em seguida, aumentar o salário do funcionário com base em uma 
            porcentagem dada (somente o salário bruto é afetado oela porcentagem) e 
            mostrar novamente os dados do funcionário. Usar a classe UML do exercício. */

            Funcionario x = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            x.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {x}");

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double prc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.AumentarSalario(prc);

            Console.WriteLine($"Dados atualizados: {x}");
        }
    }
}
