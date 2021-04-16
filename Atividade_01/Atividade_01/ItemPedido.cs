using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_01
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public string Descricao { get; set; }

        //CONSTRUTOR
        public ItemPedido(int quantidade, double valorUnitario, string descricao)
        {
            Quantidade = quantidade;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
        }
    }
}
