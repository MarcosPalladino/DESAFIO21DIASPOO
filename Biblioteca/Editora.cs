using System;

namespace Biblioteca
{
    public class Editora
    {
        public string Nome { get; set; }
        private string Descricao { get; set; }
        protected string Autor { get; set; }
        //internal string Versao { get; set; }
        public string Versao { get; set; }

        public void Acao()
        {
            new Livro().Versao = "122";
        }
    }
}
