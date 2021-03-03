using System;
using System.Globalization;

namespace _4numeroFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,
            o valor que recebe por hora e calcule o salário desse funcionário. A seguir, mostre o
            número e o salário do funcionário, com duas casas decimais.*/

            //Informar o número do funcionário. (int)
            System.Console.Write("Informe o número do funcionário: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            //Informar o número de horas trabalhadas. (int)
            System.Console.Write($"Informe o número de horas trabalhadas do funcionário {numeroFuncionario}: ");
            int horasFuncionario = int.Parse(Console.ReadLine());

            //Valor que recebe por hora. (double)
            System.Console.Write("Informe o valor que este funcionário ganha por hora: R$");
            double salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Fazendo o calculo para ssaber o total do salario. (casting)
            double salarioTotal = (double) horasFuncionario * salarioHora;

            //Apresentando para o usuário o resultado. (Saída de dados)
            System.Console.WriteLine($"NUMBER = {numeroFuncionario}");
            System.Console.WriteLine($"SALARY = R${salarioTotal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
