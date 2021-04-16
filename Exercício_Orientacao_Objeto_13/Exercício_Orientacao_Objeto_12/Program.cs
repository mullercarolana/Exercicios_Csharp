using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercício_Orientacao_Objeto_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>(); //INSERIR NOVA LISTA

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = (Console.ReadLine());

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario)); //TRANSFORMAR O INPUTT EM LIST
            }

            Console.Write("Insira o ID do Funcionário para Inserir Aumento de Salário: ");
            int procurarId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == procurarId);
            if (func != null)
            {
                Console.Write("Insira a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("ID Inválido. Insira novamente!");
            }

            Console.WriteLine("Lista Atualizada de Funcionários: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
