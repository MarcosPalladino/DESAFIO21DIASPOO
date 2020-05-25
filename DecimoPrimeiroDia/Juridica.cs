﻿using System;
using System.Collections.Generic;

namespace DecimoQuintoDia
{
    public class Juridica: Pessoa
    {
        public string Cnpj { get; set; }
        public Juridica() { }
        public override void Excluir()
        {
            Servico.Excluir(this);
        }
        public override string getDocumento()
        {
            return this.Cnpj;
        }
    }
}
