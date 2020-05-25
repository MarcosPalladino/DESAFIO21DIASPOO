using System;
using System.Collections.Generic;

namespace DecimoQuintoDia
{
    class Program
    {
        static void Main(string[] args)
        {
            new Fisica() { Nome = "Marcos Palladino", Endereco = "Rua y, 25", Id = 1, Cpf = "22323232" }.Salvar();
            new Juridica() { Nome = "Empresa Danilo", Endereco = "Rua x, 25", Id = 2, Cnpj = "4994594949" }.Salvar();

            var juridicas = Servico.Todos<List<Juridica>>();
            var fisicas = Servico.Todos<List<Fisica>>();

            foreach (Fisica fisica in fisicas)
            {
                Console.WriteLine(fisica.Cpf);
            }

            foreach (Juridica juridica in juridicas)
            {
                Console.WriteLine(juridica.Cnpj);
            }
        }
    }
}
