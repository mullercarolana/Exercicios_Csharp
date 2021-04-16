using System;

namespace Exercício_Orientacao_Objetos_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensionato[] vetor = new Pensionato[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Arrendamento #{i}: ");

                Console.WriteLine("Insira o NOME do Arrendatário: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira o E-MAIL do Arrendatário: ");
                string email = Console.ReadLine();

                Console.WriteLine("Insira o Nº do Quarto a ser Arrendado: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Pensionato(nome, email);
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }

        }
    }
}
