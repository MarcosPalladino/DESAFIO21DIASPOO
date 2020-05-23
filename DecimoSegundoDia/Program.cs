using System;
using System.Collections.Generic;

namespace DecimoTerceiroDia
{
    class Program
    {
        static void Main(string[] args)
        {
            new Fisica() { Nome = "Marcos Palladino", Endereco = "Rua y, 25", Id = 1, Cpf = "22323232" }.Salvar();
            new Juridica() { Nome = "Empresa Danilo", Endereco = "Rua x, 25", Id = 2, Cnpj = "4994594949" }.Salvar();
                        
            var listaFisica = Servico.Buscar(new Fisica());
            var listaJuridica = Servico.Buscar(new Juridica());

            foreach (Fisica fisica in listaFisica)
            {
                Console.WriteLine(fisica.Cpf);
            }

            foreach (Juridica juridica in listaJuridica)
            {
                Console.WriteLine(juridica.Cnpj);
            }
        }
    }
}
