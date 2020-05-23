using System;
namespace DecimoTerceiroDia
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
