using System;
namespace DecimoQuintoDia
{
    public interface IPessoa
    {
        void Salvar();
        void Buscar(string nome);
        void Excluir();
    }
}
