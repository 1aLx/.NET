namespace _1cotaçãoDolar
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double comprar, double cotacao)
        {
            double total = comprar * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
