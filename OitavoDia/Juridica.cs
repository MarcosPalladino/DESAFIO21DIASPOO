using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoQuintoDia
{
    public class Juridica : Pessoa
    {
        public Juridica(string nome)
        {
            this.Nome = nome;
            this.Nome = this.NomePersonalizado();
        }

        public string Cnpj { get;set; }
        public string NomeFantasia { get; set; }

        public static List<Juridica> Base = new List<Juridica>();

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

        public override void Buscar(string nome)
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Salvar()
        {
           Juridica.Base.Add(this);
        }
    }
}
