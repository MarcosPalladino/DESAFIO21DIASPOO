using System;
namespace DecimoQuintoDia
{
    public abstract class Pessoa : IPessoa
    {
        public Pessoa()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public virtual string NomePersonalizado()
        {
            return $"{this.Nome} - Aula torne-se um programador";
        }

        public abstract void Buscar(string nome);
        public abstract void Excluir();
        public abstract void Salvar();
    }
}
