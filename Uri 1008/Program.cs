using System;
using System.Globalization;

namespace Uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, salario;

            Console.WriteLine();
            Console.Write("Digite o número do funcionário : ");
            a = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.Write("Digite o número do horas trabalhadas : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o valor de cada hora trabalhada : ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = b * c;

            Console.WriteLine();
            Console.Write("Número = "+a);
           

            Console.WriteLine();
            Console.Write("Salário = R$ "+salario.ToString("F2", CultureInfo.InvariantCulture));
           

        }
    }
}
