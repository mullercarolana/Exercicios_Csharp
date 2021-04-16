using System;

namespace Exercício_Orientacao_Objeto_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x;

            x = new Aluno();

            Console.WriteLine("Insira o Nome do Aluno: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Insira a 1º Nota do Aluno (1º TRIMESTRE): ");
            x.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a 2º Nota do Aluno (2º TRIMESTRE): ");
            x.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a 3º Nota do Aluno (3º TRIMESTRE): ");
            x.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine(x);
        }
    }
}
