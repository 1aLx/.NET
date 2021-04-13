using System;

namespace _6membrosEstaticosValorNumericoPt2
{
    class Calculadora
    {
        public static double Pi = 3.14;
        
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4 * Pi * Math.Pow(r, 3) / 3;
        }
    }
}
