using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaProtectedMetodo
{
    public class Pessoa
    {
        public string Nome {get;set;}
        public string Endereco { get; set; }

        protected string NomePersonalizadoProtected()
        {
            return $"Ola metodo protected: {Nome}.";
        }
        public virtual string NomePersonalizadoVirtual()
        {
            return $"Ola Metodo Virtual: {Nome}.";
        }

    }
}
