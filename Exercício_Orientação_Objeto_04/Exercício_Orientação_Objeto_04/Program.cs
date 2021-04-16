using System;
using System.Globalization;

namespace Exercício_Orientação_Objeto_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            //DADOS PRODUTO
            Console.WriteLine("Entre os dados do produto:");

            //NOME PRODUTO
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();

            //PREÇO PRODUTO
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //QUANTIDADE NO ESTOQUE
            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            //VAI LER A CONCATENAÇÃO DO OVERRIDE TO.STRING
            Console.WriteLine("Dados do Produto: " + p);

            //ADCIONAR NO ESTOQUE
            Console.WriteLine("Insira a quantidade de produtos a ser ADCIONADO no estoque: ");
            int quant = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quant);
            Console.WriteLine("Dados Atualizados: " + p);

            //REMOVER NO ESTOQUE
            Console.WriteLine("Insira a quantidade de produtos a ser REMOVIDO no estoque: ");
            quant = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quant);
            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}
