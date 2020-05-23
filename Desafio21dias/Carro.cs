using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21dias
{
    class Carro
    {
        public Carro(string marca = "Padrão",
            string modelo = "Padrão",
            string cor = "Padrão")
        {

            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double ValorFipe { get; set; }

        public string Mostrar()
        {
            return string.Format("Carro: Marca: {0}, Modelo: {1}, Cor: {2}, Tabela Fipe: {3}",
                        this.Marca, this.Modelo, this.Cor, this.ValorFipe);
        }
    }
}
