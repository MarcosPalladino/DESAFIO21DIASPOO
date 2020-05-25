using System;
using System.Collections.Generic;

namespace DecimoQuintoDia
{
    public class Fisica: Pessoa
    {
        public string Cpf { get; set; }
        public Fisica() { }

        public sealed override void Excluir()
        {
            Servico.Excluir(this);
        }

        public override string getDocumento()
        {
            return this.Cpf;
        }

        public List<Fisica> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
