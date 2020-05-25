using System;
namespace DecimoQuintoDia
{
    public class Servico
    {
        public Servico()
        {
        }

        public static void Salvar(IPessoa iPessoa)
        {
            iPessoa.Salvar();
        }
    }
}
