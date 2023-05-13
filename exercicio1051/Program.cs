using System;
using System.Globalization;

namespace exercicio1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                if (salario <= 3000.0)
                {
                    double salarioComImposto = salario - 2000.0;
                    imposto = salarioComImposto * 0.08;
                    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (salario <= 4500.0)
                {
                    double salarioComImposto = salario - 2000.0;
                    double impostoTaxa1 = 1000.0 * 0.08;
                    double impostoTaxa2 = (salarioComImposto - 1000.0) * 0.18;
                    imposto = impostoTaxa1 + impostoTaxa2;
                    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    double salarioComImposto = salario - 2000.0;
                    double impostoTaxa1 = 1000.0 * 0.08;
                    double impostoTaxa2 = 1500.0 * 0.18;
                    double impostoTaxa3 = (salarioComImposto - 2500.0) * 0.28;
                    imposto = impostoTaxa1 + impostoTaxa2 + impostoTaxa3;
                    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}