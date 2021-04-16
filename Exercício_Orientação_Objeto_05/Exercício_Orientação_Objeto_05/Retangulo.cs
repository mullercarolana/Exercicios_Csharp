using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_Orientação_Objeto_05
{
    class Retangulo
    {
        public double Largura;
        public double Altura;      
                  
        //CALCULO AREA
        public double ValorArea()
        {
            return Largura * Altura;
        }

        //CALCULO PERIMETRO
        public double ValorPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        //CALCULO DIAGONAL
        public double ValorDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
        
        //CONCATENAÇÃO VALORES AREA/PERIMETRO/DIAGONAL
        public override string ToString()
        {
            return "Area = "
                + ValorArea()
                + Environment.NewLine
                + "Perimetro = "
                + ValorPerimetro()
                + Environment.NewLine
                + "Diagonal = "
                + ValorDiagonal();

        }

    }
}
