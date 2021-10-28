using System;
using System.Globalization;
namespace Uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double salarioFixo, totalVenda, total;

            nome = (Console.ReadLine());
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            total = totalVenda * 15.0 /100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
