using System;
using System.Collections.Generic;

namespace DecimoQuintoDia
{
    public class Fisica: Pessoa
    {
        public Fisica(string nome)
        {
            this.Nome = nome;
            this.Nome = this.NomePersonalizado();
        }

        public string CPF { get; set; }

        public override string NomePersonalizado()
        {
            return $"teste - {this.Nome}";
        }

        public string NomePersonalizado(string dado)
        {
            return $"{base.NomePersonalizado()} - testet - {dado}";
        }

        public static List<Fisica> BancoEmMemoriaDePessoasFisicas = new List<Fisica>();

        public static List<Fisica> Todas()
        {
            return Fisica.BancoEmMemoriaDePessoasFisicas;
        }

        public static void SalvarInstancia(Fisica obj)
        {
            Fisica.BancoEmMemoriaDePessoasFisicas.Add(obj);
        }

        public static List<Fisica> BuscaPorNome(string nome)
        {
            var novaLista = new List<Fisica>();
            foreach(var instan in Fisica.BancoEmMemoriaDePessoasFisicas)
            {
                if (instan.Nome.ToLower().Contains(nome.ToLower()))
                {
                    novaLista.Add(instan);
                }
            }

            return novaLista;
        }
        
        public override void Salvar()
        {
            Fisica.SalvarInstancia(this);
        }

        public override void Buscar(string nome)
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
