using System;
using System.Globalization;


namespace Exercício_Orientação_Objeto_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo A;
            A = new Retangulo();

    
            //INSERIR ALTURA
            Console.WriteLine("Insira o valor da ALTURA: ");
            A.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //INSERIR LARGURA
            Console.WriteLine("Insira o valor da LARGURA: ");
            A.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //MOSTRAR VALORES CONCATENADOS = ÁREA/PERIMETRO/DIAGONAL
            Console.WriteLine(A);
        }
    }
}
