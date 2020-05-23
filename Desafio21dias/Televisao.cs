using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21dias
{
    class Televisao
    {
        public string Marca { get; set; }
        public string Tamanho { get; set; }
        public double Preco { get; set; }
        public string Caracteristica { get; set; }

        public string Mostrar()
        {
            return string.Format("Aparelho: {0}, Tamanho: {1}, Preço: {2}, Detalhes: {3}", this.Marca, this.Tamanho, this.Preco, this.Caracteristica);
        }
    }
}
