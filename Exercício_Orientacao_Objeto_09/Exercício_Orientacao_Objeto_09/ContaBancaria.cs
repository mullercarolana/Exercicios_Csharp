using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_Orientacao_Objeto_09
{
    class ContaBancaria
    {
        public int Numero { get; private set; } // GET É EXECUTADO QUANDO A PROPRIEDADE É LIDA E SET QUANDO O VALOR É ATRIBUIDO À PROPRIEDADE
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //ENTRADA DO NÚMERO CONTA E PRINT NOME DO TITULAR
        public ContaBancaria (int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        //ADICIONADA APÓS O SALDO DA CONTA
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        //OPÇÃO DE DEPOSITAR
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        //OPÇÃO DE SAQUE COM REDUÇÃO DE R$ 5.00 DE TAXA
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
