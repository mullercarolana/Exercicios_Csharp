using System;

namespace Exercício_Orientacao_Objetos_11
{
    class Pensionato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        
        public Pensionato(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }

    }
}
