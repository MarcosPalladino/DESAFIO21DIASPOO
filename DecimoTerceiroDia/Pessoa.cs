using System;
using System.Collections.Generic;

namespace DecimoTerceiroDia
{
    public abstract class Pessoa: IPessoa
    {
        public Pessoa()
        {
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

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
