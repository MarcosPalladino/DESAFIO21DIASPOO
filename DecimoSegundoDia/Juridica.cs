using System;
using System.Collections.Generic;

namespace DecimoTerceiroDia
{
    public class Juridica: Pessoa
    {
        public string Cnpj { get; set; }
        public Juridica() { }
        public override void Excluir()
        {
            Servico.Excluir(this);
        }
        public override string getDocumento()
        {
            return this.Cnpj;
        }
        
        public List<Fisica> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
