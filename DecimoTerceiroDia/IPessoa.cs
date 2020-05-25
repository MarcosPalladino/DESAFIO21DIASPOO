using System;
using System.Collections.Generic;

namespace DecimoQuintoDia
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }

        void Salvar();
        void Excluir();
        string getDocumento();
    }
}
