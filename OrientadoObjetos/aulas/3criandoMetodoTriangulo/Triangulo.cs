using System;

namespace _3criandoMetodoTriangulo
{
    public class Triangulo
    {
        //public quer dizer que pode ser usado em outros arquivos.
        public double A;
        public double B;
        public double C;

        //Criando uma função para retirar os calculos que se repeem dentro da classe principal.
        //Método:
        //Neste caso essa função não precisa de nenhum parametro de entrada pois essa função ja esta dentro da classe. Atributos A, B e C.
        public double Area()
        {

            double p = (A + B + C) / 2.0; //Atributos da classe (lados do triangulo).
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Criando a formula de Heron dentro desta função.
            return raiz;

        }
    }
}