using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_Orientacao_Objeto_08
{
    class ConversorDeMoeda
    {
        public double CotacaoDolar, QuantCompra;

        public double ValorTotal()
        {
            return QuantCompra * CotacaoDolar;
        }

        public double ValorTotalIof()
        {
            return ValorTotal() + (0.06 * ValorTotal());
        }

        public override string ToString()
        {
            return "Valor a ser pago em reais COM IOF 6%: " 
                + ValorTotalIof().ToString("C2", CultureInfo.CurrentCulture);
        }
    }
}
