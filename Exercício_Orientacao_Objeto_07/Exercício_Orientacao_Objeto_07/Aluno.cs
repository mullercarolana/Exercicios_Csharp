using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Orientacao_Objeto_07
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool SituacaoFinal()
        {
            if (NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
                return true;
            }
            else
            {
                Console.WriteLine("REPROVADO");
                double pontos = 60 - NotaFinal();
                Console.WriteLine("FALTARAM: " + pontos);
                return false;
            }

        }

        public override string ToString()
        {
            return "Aluno: "
                + Nome
                + " sua nota final é "
                + NotaFinal()
                + " sua situação final é "
                + SituacaoFinal();
        }
    }
}
