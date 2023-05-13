using System;
using System.Globalization;

namespace exercicio1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double total;

            string[] vetor = Console.ReadLine().Split(' ');
            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);

            switch (codigo)
            {
                case 1:
                    total = quantidade * 4.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    total = quantidade * 4.5;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    total = quantidade * 5.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    total = quantidade * 2.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    total = quantidade * 1.5;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    break;
            }
        }
    }
}