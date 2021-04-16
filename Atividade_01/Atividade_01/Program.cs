using System;
using System.Collections.Generic;
using System.Globalization;

namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //NEW INSTANCIA
            Pedido novoPedido = new Pedido(); //INSTÂNCIA
            int inicioPrograma;
            int registroPedido;

            Console.WriteLine("Deseja Adicionar Novos Pedidos? 1 - Sim / 2 - Não");
            inicioPrograma = int.Parse(Console.ReadLine());

            while (inicioPrograma == 1)
            {
                Console.WriteLine("Quantos Pedidos serão Adicionados por Cliente? ");
                registroPedido = int.Parse(Console.ReadLine());

                for (int i = 1; i <= registroPedido; i++)
                {
                    Console.Write("Insira o Produto: ");
                    string descricao = Console.ReadLine();
                    Console.Write("Insira a Quantidade: ");
                    int quantidade = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Insira o Valor: ");
                    double valorUnitario = Convert.ToDouble(Console.ReadLine());

                    ItemPedido novoItem = new ItemPedido(quantidade, valorUnitario, descricao);
                    novoPedido.AdicionaPedido(novoItem);
                }
                
                Console.WriteLine("Deseja Continuar a Adicionar Pedidos? 1 - Sim / 2 - Não");
                inicioPrograma = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Obrigada Pela Preferência! Valor Total de Pedidos: " + novoPedido.TotalPedido().ToString("C2", CultureInfo.CurrentCulture));
        }
 
    }
}

