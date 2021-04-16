using System;
using System.Globalization;

//Ler o nome e salário do funcionário
//Mostra o salário médio

namespace Exercício_Orientação_Objeto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string Funcionario01;
            string Funcionario02;
            double Salario01;
            double Salario02;
            double media;


            Console.WriteLine("Insira o Nome do Funcionário: ");
            Funcionario01 = Console.ReadLine();
            Funcionario02 = Console.ReadLine();

            Console.WriteLine("Insira o salário bruto do funcionário: ");
            Salario01 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Salario02 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (Salario01 + Salario02) / 2;

            Console.WriteLine("Funcionário {0} recebe mensalmente {1} e funcionário {2} recebe mensalmente {3}", Funcionario01, Salario01.ToString("F2",CultureInfo.InvariantCulture), Funcionario02, Salario02.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Média salarial dos funcionários: " + media.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
