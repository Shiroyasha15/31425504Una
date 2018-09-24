
public class ContaPoupanca
{
    static readonly int TaxaDeJurosAnual = 4 / 100;
    static readonly int SaldoPoupanca = 0;

    private int CalcularJurosMensal(int SaldoPoupanca, int TaxaDeJurosAnual)
    {

        return (SaldoPoupanca * TaxaDeJurosAnual) / 12;

    }

    private static int AlterarTaxaDeJuros()
    {


    }



}

    
}

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
