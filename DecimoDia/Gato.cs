using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoQuintoDia
{
    public class Gato : AAnimal
    {
        //public string Nome {get;set;}
        
        public override void Andar()
        {
            if (string.IsNullOrEmpty(this.Nome))
            {
                throw new AnimalException("O nome nao pode ser vazio");

            }
            throw new Exception();
        }

        public override void Correr()
        {
            throw new NotImplementedException();
        }
    }
}
