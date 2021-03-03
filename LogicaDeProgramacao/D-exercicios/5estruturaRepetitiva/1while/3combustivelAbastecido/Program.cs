using System;

namespace _3combustivelAbastecido
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um Posto de combustíveis deseja determinar qual de seus produtos tem a 
            preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível 
            abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). 
            Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo 
            código (até que seja válido). O programa será encerrado quando o código informado for o número 4. 
            Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo 
            de combustível, conforme exemplo.*/

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            System.Console.Write("Informe o código do combustível desejado: ");
            int variable = int.Parse(Console.ReadLine());

            while (variable != 4) //O pograma será encerrado quando o usuário digitar 4.
            {
                if (variable == 1)
                {
                    alcool++; //Alcool.
                }
                else if (variable == 2)
                {
                    gasolina++; //Gasolina.
                }
                else if (variable == 3)
                {
                    diesel++; //Diesel.
                }

                System.Console.Write("informe novamente um código: ");
                variable = int.Parse(Console.ReadLine());

            }

            System.Console.WriteLine("Muito obrigado.");
            System.Console.WriteLine($"Alcool: {alcool}");
            System.Console.WriteLine($"Gasoline: {gasolina}");
            System.Console.WriteLine($"Diesel: {diesel}");

            //Exercicio baseado em votações.

        }
    }
}
