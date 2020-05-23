using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaProtectedMetodo
{
    public class Fisica : Pessoa
    {
        public Fisica(string nome) {
            this.Nome = nome;
            this.Nome = this.NomePersonalizadoProtected();
            this.Nome = this.NomePersonalizadoVirtual();
        }

        public Fisica()
        {
        }

        public string Cpf { get; set; }
        public string Rg { get; set; }

        //sobrescrevendo um metodo protected na herança
        public new string NomePersonalizadoProtected()
        {
            return $"sobrescrevendo meu nome é {base.NomePersonalizadoProtected()}";
        }

        //incluindo mais uma assinatura para o metodo protected na heranca.
        public string NomePersonalizadoProtected(string _nome)
        {
            return $"{base.NomePersonalizadoProtected()}sobrescrevendo meu nome é {_nome}";
        }

        //sobrescrevendo metodo virtual na herança
        public override string NomePersonalizadoVirtual()
        {
            return $"sobrescrevendo meu nome é {base.NomePersonalizadoVirtual()}";
        }

        //incluindo mais uma assinatura para o metodo virtual.
        public string NomePersonalizadoVirtual(string _nome)
        {
            return $"{base.NomePersonalizadoVirtual()}sobrescrevendo meu nome é {_nome}";
        }
    }
}
