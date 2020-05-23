using System;
using System.Collections.Generic;
using System.Text;

namespace VariaveisMetodosStaticos
{
    public class Juridica : Pessoa
    {
        public string Cnpj { get;set; }
        public string NomeFantasia { get; set; }

        public static List<Juridica> Base = new List<Juridica>();
        public void Salvar()
        {
            Juridica.Base.Add(this);
        }

        public static List<Juridica> BuscaPorNome(string nome)
        {
            var novaLista = new List<Juridica>();
            foreach (var instan in Juridica.Base)
            {
                if (instan.Nome.ToLower().Contains(nome.ToLower()))
                {
                    novaLista.Add(instan);
                }
            }
            return novaLista;
        }
    }
}
