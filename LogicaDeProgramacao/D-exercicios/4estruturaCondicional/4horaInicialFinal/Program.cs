using System;

namespace _4horaInicialFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia a hora inicial e a hora final de um jogo. A seguir. calcule a duração do jogo,
            sabendo que o mesmo pode começar em m dia e terminar em outro, tendo um duração 
            mínima de 1 hora e máxima de 24 horas.*/

            System.Console.Write("Informe a hora inicial e final do jogo: ");
            string [] valores = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int totalPartida; //calculo para duração total da partida.
            
            if (horaInicio < horaFinal) // 16 < 2 == false
            {
                totalPartida = horaFinal - horaInicio;
            }
            else
            {
                totalPartida = 24 - horaInicio + horaFinal; // 24 - 16 + 2 == 10 horas.
            }

            System.Console.WriteLine($"O JOGO DUROU: {totalPartida} HORA(S).");
        }
    }
}
