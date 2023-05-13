using System;
using System.Globalization;

namespace exercicio1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] V = Console.ReadLine().Split(' ');
            double N1 = double.Parse(V[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(V[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(V[2], CultureInfo.InvariantCulture);

            double A, B, C;

            if (N1 > N2 && N1 > N3)
            {
                A = N1;

                if (N2 > N3)
                {
                    B = N2;
                    C = N3;
                }
                else
                {
                    B = N3;
                    C = N2;
                }
            }
            else if (N2 > N3)
            {
                A = N2;

                if (N1 > N3)
                {
                    B = N1;
                    C = N3;
                }
                else
                {
                    B = N3;
                    C = N1;
                }
            }
            else
            {
                A = N3;

                if (N1 > N2)
                {
                    B = N1;
                    C = N2;
                }
                else
                {
                    B = N2;
                    C = N1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (A * A == B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (A * A > B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}