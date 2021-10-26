using System;
using System.Globalization;

namespace Uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qtd1, qtd2;
            double preco1, preco2, total;

            string[] vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            qtd1 = int.Parse(vet[1]);
            preco1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet[0]);
            qtd2 = int.Parse(vet[1]);
            preco2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = preco1 * qtd1 + preco2 * qtd2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
