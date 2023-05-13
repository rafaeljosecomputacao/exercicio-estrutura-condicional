using System;
using System.Globalization;

namespace exercicio1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, M, NE, MF;

            string[] V = Console.ReadLine().Split(' ');
            N1 = float.Parse(V[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(V[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(V[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(V[3], CultureInfo.InvariantCulture);

            M = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / (2 + 3 + 4 + 1);

            if (M == 4.85f)
            {
                M = 4.8f;
            }

            Console.WriteLine("Media: " + M.ToString("F1", CultureInfo.InvariantCulture));

            if (M < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (M >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");

                NE = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota do exame: " + NE.ToString("F1", CultureInfo.InvariantCulture));

                MF = (M + NE) / 2;

                if (MF >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + MF.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}