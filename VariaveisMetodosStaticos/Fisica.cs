using System;
using System.Collections.Generic;
using System.Text;

namespace VariaveisMetodosStaticos
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

        public static List<Fisica> Base = new List<Fisica>();
        public void Salvar()
        {
            Fisica.Base.Add(this);
        }

        public static List<Fisica> BuscaPorNome(string nome)
        {
            var novaLista = new List<Fisica>();
            foreach (var instan in Fisica.Base)
            {
                if (instan.Nome.ToLower().Contains(nome.ToLower()))
                {
                    novaLista.Add(instan);
                }
            }

            return novaLista;
        }

        public static List<Fisica> Todas()
        {
            return Base;
        }
    }
}
