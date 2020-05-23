using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21dias
{
    class Receita
    {
        public Receita(string nome = "")
        {
            this.Nome = nome;
        }

        public string Tamanho { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }
        public string Nome { get; set; }

        private void Salvar()
        {

        }

        private void Mostrar()
        {

        }
    }
}
