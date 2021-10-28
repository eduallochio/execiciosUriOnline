using System;
using System.Globalization;
namespace Uri_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tempo, Velocidade, Distancia;
            double litros;

            Tempo = int.Parse(Console.ReadLine());
            Velocidade = int.Parse(Console.ReadLine());

            Distancia = Tempo * Velocidade;

            litros = Distancia / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
