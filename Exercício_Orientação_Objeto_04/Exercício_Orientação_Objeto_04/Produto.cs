using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_Orientação_Objeto_04
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //VALOR TOTAL EM ESTOQUE
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //ADCIONAR ESTOQUE
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        //REMOVER ESTOQUE
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        //LEITURA CONCATENAÇÃO ToString
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
