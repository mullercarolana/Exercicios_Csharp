using System;
using System.Globalization;

namespace Exercício_Orientacao_Objeto_09
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            //INSERIR NÚMERO DA CONTA
            Console.WriteLine("Número da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            //INSERIR TITULAR DA CONTA
            Console.WriteLine("Titular da Conta: ");
            string titular = (Console.ReadLine());

            //OPÇÃO DE DEPÓSITO INCIAL
            Console.WriteLine("Haverá Depósito Inicial?  S - SIM / N - NÃO");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Entre com o Valor de Depósito Inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um Valor para Depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um Valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
