using System;
using System.Globalization;

namespace _8impostoSobreSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Em um país imaginário denominado Lisarb, todos os habitantes ficam 
            felizes em pagar seus impostos, pois sabem que nele não existem políticos
            corruptos e os recursos arrecadados são utilizados em benefício da população, 
            sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. Leia 
            um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb.
            Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de 
            Renda, segundo a tabela abaixo. */

            System.Console.Write("Informe a sua renda: R$");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0.0;

            if (renda <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (renda <= 3000.00)
            {
                imposto = (renda - 2000.00) * 0.08;
            }
            else if (renda <= 4500.00)
            {
                imposto = (renda - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else
            {
                imposto = (renda - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }
            
            if (imposto == 0.0)
            {
                System.Console.WriteLine("Insento.");
            }
            else
            {
                System.Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
