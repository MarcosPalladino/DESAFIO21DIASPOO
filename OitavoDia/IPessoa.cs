using System;
namespace DecimoTerceiroDia
{
    public interface IPessoa
    {
        void Salvar();
        void Buscar(string nome);
        void Excluir();
    }
}
