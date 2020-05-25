using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoQuintoDia
{
    public abstract class AAnimal
    {
        public string Nome { get; set; }
        public abstract void Andar();
        public abstract void Correr();
    }
}
