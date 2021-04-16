using System;
using System.Globalization;

namespace Exercício_Orientacao_Objeto_08
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda x;

            x = new ConversorDeMoeda();
            
            Console.WriteLine("Cotação do Dólar: ");
            x.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade de Dólares para Compra: ");
            x.QuantCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(x);
        }
    }
}
