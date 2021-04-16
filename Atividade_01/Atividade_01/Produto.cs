using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_01
{
    class Pedido
    {
        List<ItemPedido> itemPedido;

        public Pedido() //INSTÂNCIA 
        {
            itemPedido = new List<ItemPedido>();
        }

        public void AdicionaPedido(ItemPedido item)
        {
            itemPedido.Add(item);
        }

        public double TotalPedido()
        {
            double total = 0;
            foreach (var item in itemPedido)
            {
                total += item.ValorUnitario * item.Quantidade;
            }
            return total;
        }
    }
}
