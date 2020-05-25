using System;
using System.Collections.Generic;

namespace DecimoQuintoDia
{
    public abstract class Pessoa: IPessoa
    {
        public Pessoa()
        {
        }

        private string endereco;
        private string nome;

        public int Id { get; set; }
        
        public string Nome {
            get
            {
                return nome.ToUpper();
            }
            set
            {
                nome = value.ToLower();
            }
        }

        public string Endereco { 
            get {
                return endereco.ToUpper();
            }
            set {
                endereco = value.ToLower();
            }
        }

        public abstract void Excluir();
        public abstract string getDocumento();

        public List<Pessoa> Todos()
        {
            return Servico.Todos<List<Pessoa>>();
        }
        
        public List<Fisica> ToList()
        {
            throw new NotImplementedException();
        }

        public void Salvar()
        {
            Servico.Salvar(this);
        }
        public override string ToString()
        {
            return this.Nome;
        }
    }
}
