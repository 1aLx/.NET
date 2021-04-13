using System;
using System.Globalization;

namespace _3retangulo
{
    public class Retangulo
    {
        public double Largura; //Atributo base.
        public double Altura; //Atributo altura.

        public double Area() //Função para calcular a area.
        {
            return Largura * Altura;
        }

        public double Perimetro() //Função para calcular o perímetro do retÂngulo.
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal() //E por fim, calcular a diaonal do retângulo.
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString() //Apresentando a saida de dados para o usuário. (System.Console.WriteLine(x);)
        {
            return
            "Area = " +
            Area().ToString("F2", CultureInfo.InvariantCulture) +
            "\n" +
            "Perímetro = " +
            Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
            "\n" +
            "Diagonal = " +
            Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}