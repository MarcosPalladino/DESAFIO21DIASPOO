using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21dias
{
    class Animal
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Sexo { get; set; }

        public string Mostrar()
        {
            return string.Format("Animal: Nome: {0}, Tipo: {1}, Sexo: {2}",this.Nome, this.Tipo, this.Sexo);
        }
    }
}
