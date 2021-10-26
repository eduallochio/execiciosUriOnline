using System;

namespace Uri_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ano, Mes, Dia, Soma, Entrada;

            Entrada = int.Parse(Console.ReadLine());

            Ano = Entrada / 365;
            Mes = Entrada %355 / 30;
            Dia = Mes / 30;
            

            Console.WriteLine(${Ano} { Mes}, { Dia} );






        }
    }
}
