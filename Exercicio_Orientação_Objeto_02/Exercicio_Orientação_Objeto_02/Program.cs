using System;
using System.Globalization;

namespace Exercicio_Orientação_Objeto_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario x, y;

            x = new Salario();
            y = new Salario();

            Funcionario f, fc;

            f = new Funcionario();
            fc = new Funcionario();

            Console.WriteLine("Insira o Nome do Funcionário: ");
            f.A = Console.ReadLine();
            fc.B = Console.ReadLine();

            Console.WriteLine("Insira o Salário do Funcionário: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (x.A + x.B) / 2;

            Console.WriteLine("Funcionário {0} recebe mensalmente {1}", f.A, x.A.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Funcionário {0} recebe mensalmente {1}", fc.B, x.B.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Média Salarial: " + media.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
