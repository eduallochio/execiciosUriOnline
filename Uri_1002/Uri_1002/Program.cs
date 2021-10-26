using System;
using System.Globalization;
namespace Uri_1002
{
    class Program
    {
        static void Main(string[] args)
        {

            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine());

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
