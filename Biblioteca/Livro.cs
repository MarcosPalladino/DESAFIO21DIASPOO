using System;

namespace Biblioteca
{
    public class Livro
    {
        public string Nome { get; set; }
        private string Descricao { get; set; }
        protected string Autor { get; set; }
        internal string Versao { get; set; }
        //public string Versao { get; set; }
    }
}
