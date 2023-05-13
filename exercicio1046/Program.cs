using System;

namespace exercicio1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            string[] vetor = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vetor[0]);
            horaFinal = int.Parse(vetor[1]);

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}