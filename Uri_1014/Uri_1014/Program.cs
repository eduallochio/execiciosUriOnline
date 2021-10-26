using System;
using System.Globalization;
namespace Uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, KM;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            KM = X / Y;

            Console.WriteLine(KM.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
