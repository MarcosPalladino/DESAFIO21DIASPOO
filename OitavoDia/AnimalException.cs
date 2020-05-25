using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoQuintoDia
{
    public class AnimalException: Exception
    {
        private string mensagem;
        public AnimalException(string mensagem)
        {
            this.mensagem = mensagem;
        }
        public override string ToString()
        {
            return this.mensagem;
        }
        public override string Message => this.mensagem;
    }
}
