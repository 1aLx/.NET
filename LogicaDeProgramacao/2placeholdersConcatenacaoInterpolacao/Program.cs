using System;
using System.Globalization;

namespace placeholdersConcatenacaoInterpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazendo uma interpolação de variaveis em Console.Write.

            int idade = 21;
            double saldo = 651.98654;
            string nome = "Eduarda";

            //Placeholder.
            System.Console.WriteLine("{0} tem {1} anos e seu saldo é: R${2}", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));

            //Interpolação.
            System.Console.WriteLine($"{nome} tem {idade} anos e seu saldo é: R${saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            //Concatenação.
            System.Console.WriteLine(nome + " tem " + idade + " anos e seu saldo é: R$" + saldo.ToString("F2", CultureInfo.InvariantCulture));

            //.ToString("F2") = arredonda um valor e apresenta somente com dois valores depois da virgula.
            //CultureInfo.InvariantCulture = função para retirada da virgula de um valor decimal (BR).
        }
    }
}
