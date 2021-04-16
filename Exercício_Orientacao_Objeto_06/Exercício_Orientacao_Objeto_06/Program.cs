using System;
using System.Globalization;

namespace Exercício_Orientacao_Objeto_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x;
            x = new Funcionario();

            //INSERIR NOME FUNCIONÁRIO
            Console.WriteLine("Insira Nome do Funcionário: ");
            x.Nome = Console.ReadLine();

            //INSERIR SALÁRIO FUNCIONÁRIO
            Console.WriteLine("Insira Salário do Funcionário: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            //INSERIR VALOR DESCONTO IMPOSTO
            Console.WriteLine("Insira Valor Desconto Impostos: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            //INCERIR PORCENTAGEM AUMENTO SALÁRIO
            Console.WriteLine("Insira Porcentagem de Aumento do Salário: ");
            x.Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário " + x.Nome + " - Salário sem Impostos: " + x.SalarioLiquido().ToString("C2", CultureInfo.CurrentCulture));

            Console.WriteLine(x);

        }
    }
}
