using System;

namespace Exercício_Orientação_Objeto_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASSE IDADE.CS
            Idade a, b;
            a = new Idade();
            b = new Idade();

            //CLASE IDADE.CS
            Pessoa A, B;
            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Digite o nome da 1º Pessoa: ");
            A.Pessoa1 = Console.ReadLine();
            Console.WriteLine("Digite o nome da 2º Pessoa: ");
            B.Pessoa2 = Console.ReadLine();

            Console.WriteLine("Digite a idade da 1º Pessoa: ");
            a.Idade1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade da 2º Pessoa: ");
            b.Idade2 = byte.Parse(Console.ReadLine());

            if (a.Idade1 > b.Idade2)
            {
                Console.WriteLine("Pessoa mais VELHA: " + A.Pessoa1);
            }
            else
            {
                Console.WriteLine("Pessoa mais VELHA: " + B.Pessoa2);
            }
        }
    }
}
