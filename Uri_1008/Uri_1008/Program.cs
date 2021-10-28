using System;
using System.Globalization;
namespace Uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double salario, total;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = horas * salario;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}