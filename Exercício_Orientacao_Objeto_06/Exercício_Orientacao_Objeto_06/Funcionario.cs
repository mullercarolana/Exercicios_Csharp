using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_Orientacao_Objeto_06
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Porcentagem;


        //CALCULO SALÁRIO LIQUIDO
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        //CALCULO AUMENTO DE SALÁRIO
        public double AumentarSalario()
        {
            return (Porcentagem * SalarioBruto) / 100 + SalarioLiquido();
        }

        //CONCATENAÇÃO
        public override string ToString()
        {
            return "Dados Atualizados: "
                + Nome
                + ", Salário com Aumento:"
                + AumentarSalario().ToString("C2", CultureInfo.CurrentCulture);
                
        }
      
       
    }
}
